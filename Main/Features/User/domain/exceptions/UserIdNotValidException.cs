namespace APPOINTMENT_SERVICE_API.Main.Features.User.domain.exceptions;

public class UserIdNotValidException : Exception
{
    public UserIdNotValidException(string message) : base(message) { }
}