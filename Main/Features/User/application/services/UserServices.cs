using APPOINTMENT_SERVICE_API.Main.Features.User.application.dtos;
using APPOINTMENT_SERVICE_API.Main.Features.User.domain.exceptions;
using APPOINTMENT_SERVICE_API.Main.Features.User.domain.mappers;
using APPOINTMENT_SERVICE_API.Main.Features.User.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.User.infrastructure.repository;
using APPOINTMENT_SERVICE_API.Main.Root.Shared.Dtos;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.application.services;

public class UserServices : IUserServiceInPort
{
    private readonly UserMapper _userMapper;
    private readonly IUserRepositoryOutPort _userRepository;

    public UserServices(UserMapper userMapper, IUserRepositoryOutPort userRepository)
    {
        _userMapper = userMapper;
        _userRepository = userRepository;
    }

    public PaginatedUsersResponseDTO GetAllUsers(int page, int size, Guid? CompanyUuid)
    {
        var paginatedUsersResponseDto = new PaginatedUsersResponseDTO();

        var userList = _userRepository.FindAll();
        var users = _userRepository.FindAll(page, size, CompanyUuid)
            .Select(_userMapper.ToResponseDto)
            .ToList();

        var paginationResponseDto = new PaginationResponseDTO();

        int totalPages = (int)Math.Ceiling((double)userList.Count / size);
        int? nextPage = page + 1;
        if (page + 1 >= totalPages)
        {
            nextPage = null;
        }

        paginationResponseDto.CurrentPage = page;
        paginationResponseDto.TotalItems = userList.Count;
        paginationResponseDto.NextPage = nextPage;
        paginationResponseDto.TotalPages = totalPages;
        paginationResponseDto.TotalCurrentItems = users.Count;

        paginatedUsersResponseDto.Users = users;
        paginatedUsersResponseDto.PaginationResponseDTO = paginationResponseDto;

        return paginatedUsersResponseDto;
    }

    public UserResponseDTO GetUserById(string id)
    {
        if (Guid.TryParse(id, out Guid uuid))
        {
            var user = _userRepository.FindByUuid(uuid);
            return user != null ? _userMapper.ToResponseDto(user) : throw new UserNotFoundException("User not found with uuid " + uuid);
        }
        else if (long.TryParse(id, out long longId))
        {
            var user = _userRepository.FindById(longId);
            return user != null ? _userMapper.ToResponseDto(user) : throw new UserNotFoundException("User not found with id " + longId);
        }

        throw new UserIdNotValidException("User id is not valid");
    }

    public UserResponseDTO CreateUser(UserCreateRequestDTO userCreateRequestDto)
    {
        var existingUser = _userRepository.FindByEmail(userCreateRequestDto.Email);
        if (existingUser != null)
        {
            throw new UserConflictException("User already exists with email " + userCreateRequestDto.Email);
        }

        var userModel = new UserModel()
        {
            Name = userCreateRequestDto.Name,
            Email = userCreateRequestDto.Email,
            Password = userCreateRequestDto.Password 
        };

        return _userMapper.ToResponseDto(_userRepository.Create(userModel));
    }

    public UserResponseDTO UpdateUser(long id, UserUpdateRequestDTO dto)
    {
        var model = _userRepository.FindById(id);
        if (model == null)
        {
            throw new UserNotFoundException("User not found with id " + id);
        }

        if (!string.IsNullOrWhiteSpace(dto.Name))
        {
            model.Name = dto.Name;
        }

        if (!string.IsNullOrWhiteSpace(dto.Email))
        {
            var existingUser = _userRepository.FindByEmail(dto.Email);
            if (existingUser != null && existingUser.Id != id)
            {
                throw new UserConflictException("Email " + dto.Email + " is already in use");
            }

            model.Email = dto.Email;
        }

        return _userMapper.ToResponseDto(_userRepository.Update(model));
    }
    
    public void DeleteUser(long id)
    {
        var model = _userRepository.FindById(id);
        if (model == null)
        {
            throw new UserNotFoundException("User not found with id " + id);
        }

        _userRepository.DeleteById(id);
    }
}