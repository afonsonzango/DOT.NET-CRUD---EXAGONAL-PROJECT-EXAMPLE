using APPOINTMENT_SERVICE_API.Main.Root.Shared.Dtos;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.application.dtos;

public class PaginatedUsersResponseDTO
{
    public PaginationResponseDTO PaginationResponseDTO { get; set; }
    public List<UserResponseDTO> Users { get; set; }
}