namespace APPOINTMENT_SERVICE_API.Main.Root.Shared.Dtos;

public class ErrorResponseDto
{
    public string Code { get; set; }
    public string Message { get; set; }
    public Dictionary<string, List<string>>? Errors { get; set; } // optional

    public ErrorResponseDto(string code, string message, Dictionary<string, List<string>>? errors = null)
    {
        Code = code;
        Message = message;
        Errors = errors;
    }
}