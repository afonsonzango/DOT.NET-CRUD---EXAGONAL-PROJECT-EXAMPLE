using System.ComponentModel.DataAnnotations;
using APPOINTMENT_SERVICE_API.Main.Features.Company.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Features.User.infrastructure.entity;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Entities;

namespace APPOINTMENT_SERVICE_API.Main.Features.Role.infrastructure.entity;

public class RoleEntity : BaseEntity
{
    [Required]
    public string Name { get; set; }
    
    public string Description { get; set; } = string.Empty;
    
    [Required]
    public int CompanyId { get; set; }
    public CompanyEntity Company { get; set; }
    
    public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>();
}