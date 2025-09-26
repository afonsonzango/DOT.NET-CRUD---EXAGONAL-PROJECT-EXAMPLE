using System.ComponentModel.DataAnnotations;
using APPOINTMENT_SERVICE_API.Main.Features.Company.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Employee.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.domain.enums;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Entities;

namespace APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.infrastructure.entity;

public class WorkScheduleEntity : BaseEntity
{
    [Required]
    public DateTime WorkDate { get; set; }
    
    [Required]
    public WeekDayEnum WeekDay { get; set; }
    
    [Required]
    public TimeSpan StartTime { get; set; }
    
    [Required]
    public TimeSpan EndTime { get; set; }

    [Required]
    public int CompanyId { get; set; }
    public CompanyEntity Company { get; set; }
    
    public ICollection<EmployeeEntity> Employees { get; set; } = new List<EmployeeEntity>();
}