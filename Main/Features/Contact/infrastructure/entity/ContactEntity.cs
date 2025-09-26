using System.ComponentModel.DataAnnotations;
using APPOINTMENT_SERVICE_API.Main.Features.Client.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Contact.domain.enums;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Entities;

namespace APPOINTMENT_SERVICE_API.Main.Features.Contact.infrastructure.entity;

public class ContactEntity : BaseEntity
{
    [Required]
    public string Value { get; set; }
 
    [Required]
    public ContactTypeEnum type { get; set; }
    
    [Required]
    public int ClientId { get; set; }
    public ClientEntity Client { get; set; }
}