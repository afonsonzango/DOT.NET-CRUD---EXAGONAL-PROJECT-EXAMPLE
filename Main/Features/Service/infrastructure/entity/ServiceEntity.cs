using System.ComponentModel.DataAnnotations;
using APPOINTMENT_SERVICE_API.Main.Features.Booking.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Company.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Entities;

namespace APPOINTMENT_SERVICE_API.Main.Features.Service.infrastructure.entity;

public class ServiceEntity : BaseEntity
{
    [Required]
    public string Name { get; set; }
    
    public string Description { get; set; } = string.Empty;
    
    [Required]
    public int DurationMinutes { get; set; }

    [Required] 
    public int EmployeesRequired { get; set; } = 1;

    [Required]
    public int CompanyId { get; set; }
    public CompanyEntity Company { get; set; }
    
    public ICollection<BookingEntity> Bookings { get; set; } = new List<BookingEntity>();
}