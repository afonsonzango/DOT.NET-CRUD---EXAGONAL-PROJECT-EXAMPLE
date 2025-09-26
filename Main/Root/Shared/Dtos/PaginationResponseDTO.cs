namespace APPOINTMENT_SERVICE_API.Main.Root.Shared.Dtos;

public class PaginationResponseDTO
{
    public int CurrentPage { get; set; }
    public int TotalItems { get; set; }
    public int? NextPage { get; set; }
    public int TotalPages { get; set; }
    public int TotalCurrentItems { get; set; }
}