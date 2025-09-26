using System.ComponentModel.DataAnnotations;
using APPOINTMENT_SERVICE_API.Main.Features.Company.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.User.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Entities;

namespace APPOINTMENT_SERVICE_API.Main.Features.Employee.infrastructure.entity;

public class EmployeeEntity : BaseEntity
{
    [Required]
    public string FirstName { get; set; }
    
    [Required]
    public string LastName { get; set; }

    public string Email { get; set; } = string.Empty;
    
    [Required]
    public string PhoneNumber { get; set; }
    
    [Required]
    public int UserId { get; set; }
    public UserEntity User { get; set; }

    [Required]
    public int CompanyId { get; set; }
    public CompanyEntity Company { get; set; }

    [Required]
    public DateTime HiredAt { get; set; } = DateTime.UtcNow;
    
    [Required]
    public bool Active { get; set; } = true;

    public ICollection<WorkScheduleEntity> WorkSchedules { get; set; } = new List<WorkScheduleEntity>();
}