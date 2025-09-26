using System.ComponentModel.DataAnnotations;
using APPOINTMENT_SERVICE_API.Main.Features.Address.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Booking.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Company.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Contact.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Entities;

namespace APPOINTMENT_SERVICE_API.Main.Features.Client.infrastructure.entity;

public class ClientEntity : BaseEntity
{
    [Required]
    public string Name { get; set; }
    
    public string Email { get; set; }

    [Required]
    public int CompanyId { get; set; }
    public CompanyEntity Company { get; set; }
    
    public ICollection<AddressEntity> Addresses { get; set; } = new List<AddressEntity>();

    public ICollection<ContactEntity> Contacts { get; set; } = new List<ContactEntity>();
    
    public ICollection<BookingEntity> Bookings { get; set; } = new List<BookingEntity>();
}