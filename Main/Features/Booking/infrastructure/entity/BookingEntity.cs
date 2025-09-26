using System.ComponentModel.DataAnnotations;
using APPOINTMENT_SERVICE_API.Main.Features.Booking.domain.enums;
using APPOINTMENT_SERVICE_API.Main.Features.Client.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Company.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Service.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Entities;

namespace APPOINTMENT_SERVICE_API.Main.Features.Booking.infrastructure.entity;

public class BookingEntity : BaseEntity
{   
    [Required]
    public DateTime StartTime { get; set; }
    
    [Required]
    public DateTime EndTime { get; set; }

    [Required]
    public BookingStatusEnum Status { get; set; } = BookingStatusEnum.Scheduled;

    [Required]
    public int ClientId { get; set; }
    public ClientEntity Client { get; set; }

    [Required]
    public int ServiceId { get; set; }
    public ServiceEntity Service { get; set; }

    [Required]
    public int CompanyId { get; set; }
    public CompanyEntity Company { get; set; }
}