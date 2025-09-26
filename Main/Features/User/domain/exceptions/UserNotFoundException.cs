namespace APPOINTMENT_SERVICE_API.Main.Features.User.domain.exceptions;

public class UserNotFoundException : Exception
{
    public UserNotFoundException(string message) : base(message) { }
}