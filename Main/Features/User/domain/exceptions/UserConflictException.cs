namespace APPOINTMENT_SERVICE_API.Main.Features.User.domain.exceptions;

public class UserConflictException : Exception
{
    public UserConflictException(string message) : base(message) { }
}