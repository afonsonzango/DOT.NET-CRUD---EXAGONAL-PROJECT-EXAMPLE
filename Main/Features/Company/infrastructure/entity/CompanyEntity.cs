using System.ComponentModel.DataAnnotations;
using APPOINTMENT_SERVICE_API.Main.Features.Booking.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Client.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Employee.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Role.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Service.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.User.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Entities;

namespace APPOINTMENT_SERVICE_API.Main.Features.Company.infrastructure.entity;

public class CompanyEntity : BaseEntity
{
    [Required]
    public string Name { get; set; }
    
    public string? Description { get; set; } = string.Empty;

    [Required]
    public TimeSpan OpeningTime { get; set; }
    
    [Required]
    public TimeSpan ClosingTime { get; set; }

    [Required] 
    public int EmployeesCount { get; set; }
    
    public ICollection<EmployeeEntity> Employees { get; set; } = new List<EmployeeEntity>();
    
    public ICollection<ServiceEntity> Services { get; set; } = new List<ServiceEntity>();
    
    public ICollection<ClientEntity> Clients { get; set; } = new List<ClientEntity>();
    
    public ICollection<BookingEntity> Bookings { get; set; } = new List<BookingEntity>();

    public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>();
    
    public ICollection<RoleEntity> Roles { get; set; } = new List<RoleEntity>();
}