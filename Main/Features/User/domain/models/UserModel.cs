using APPOINTMENT_SERVICE_API.Main.Features.Company.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Employee.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Role.domain.models;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Models;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.domain.models;

public class UserModel : BaseModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public ICollection<RoleModel> Roles { get; set; } = new List<RoleModel>();
    public ICollection<CompanyModel> Companies { get; set; } = new List<CompanyModel>();
    public ICollection<EmployeeModel> Employees { get; set; } = new List<EmployeeModel>();
}