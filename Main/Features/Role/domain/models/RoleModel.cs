using APPOINTMENT_SERVICE_API.Main.Features.Company.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.User.domain.models;

namespace APPOINTMENT_SERVICE_API.Main.Features.Role.domain.models;

public class RoleModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public CompanyModel Company { get; set; }
    public ICollection<UserModel> Users { get; set; } = new List<UserModel>();
}