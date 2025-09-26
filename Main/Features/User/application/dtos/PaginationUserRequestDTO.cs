namespace APPOINTMENT_SERVICE_API.Main.Features.User.application.dtos;
using System.ComponentModel.DataAnnotations;

public class PaginationUserRequestDTO
{
    [Range(0, int.MaxValue, ErrorMessage = "A página deve ser maior ou igual a 0")]
    public int Page { get; set; } = 0;

    [Range(1, 100, ErrorMessage = "O tamanho deve ser entre 1 e 100")]
    public int Size { get; set; } = 10;
}