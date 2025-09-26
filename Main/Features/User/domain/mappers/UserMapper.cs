using APPOINTMENT_SERVICE_API.Main.Features.User.application.dtos;
using APPOINTMENT_SERVICE_API.Main.Features.User.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.User.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.domain.mappers;

public class UserMapper
{
    private readonly IMapper _mapper;
    
    public UserMapper(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public UserModel ToModel(UserEntity entity)
    {
        return _mapper.Map<UserModel>(entity);
    }

    public UserEntity ToEntity(UserModel model)
    {
        return _mapper.Map<UserEntity>(model);
    }

    public UserResponseDTO ToResponseDto(UserModel model)
    {
        return _mapper.Map<UserResponseDTO>(model);
    }
}