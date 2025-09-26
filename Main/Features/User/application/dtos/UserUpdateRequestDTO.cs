namespace APPOINTMENT_SERVICE_API.Main.Features.User.application.dtos;
using System.ComponentModel.DataAnnotations;

public class UserUpdateRequestDTO
{
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
    public string? Name { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string? Email { get; set; }
}
