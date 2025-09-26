using System.ComponentModel.DataAnnotations;
using APPOINTMENT_SERVICE_API.Main.Features.Client.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Entities;

namespace APPOINTMENT_SERVICE_API.Main.Features.Address.infrastructure.entity;

public class AddressEntity : BaseEntity
{
    [Required] 
    public string? City { get; set; }
    
    public string? State { get; set; } = string.Empty;

    public string? ZipCode { get; set; } = string.Empty;
 
    public string? Street { get; set; } = string.Empty;
    
    [Required]
    public string Country { get; set; } = string.Empty;
    
    [Required]
    public int ClientId { get; set; }
    public ClientEntity Client { get; set; }
}