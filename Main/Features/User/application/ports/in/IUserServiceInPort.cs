using APPOINTMENT_SERVICE_API.Main.Features.User.application.dtos;

public interface IUserServiceInPort
{
    PaginatedUsersResponseDTO GetAllUsers(int page, int size);

    UserResponseDTO GetUserById(string id);

    UserResponseDTO CreateUser(UserCreateRequestDTO userCreateRequestDTO);

    UserResponseDTO UpdateUser(long id, UserUpdateRequestDTO userUpdateRequestDTO);

    void DeleteUser(long id);
}