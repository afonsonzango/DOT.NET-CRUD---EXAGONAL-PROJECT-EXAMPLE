using System.ComponentModel.DataAnnotations;
using APPOINTMENT_SERVICE_API.Main.Features.Company.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Employee.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.Role.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Entities;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.infrastructure.entity;

public class UserEntity : BaseEntity
{   
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
    
    public ICollection<RoleEntity> Roles { get; set; } = new List<RoleEntity>();
    
    public ICollection<CompanyEntity> Companies { get; set; } = new List<CompanyEntity>();

    public ICollection<EmployeeEntity> Employees { get; set; } = new List<EmployeeEntity>();
}