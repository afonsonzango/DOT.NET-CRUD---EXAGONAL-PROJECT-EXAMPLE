namespace APPOINTMENT_SERVICE_API.Main.Features.User.application.dtos;
using System.ComponentModel.DataAnnotations;

public class UserCreateRequestDTO
{
    [Required(ErrorMessage = "Name cannot be null")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email cannot be null")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password cannot be null")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 100 characters")]
    public string Password { get; set; }
}