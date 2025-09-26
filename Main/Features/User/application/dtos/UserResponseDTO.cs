using APPOINTMENT_SERVICE_API.Main.Features.Company.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Employee.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Role.domain.models;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.application.dtos;

public class UserResponseDTO
{
    public long Id { get; set; }
    public Guid Uuid { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<RoleModel> Roles { get; set; }
    public List<CompanyModel> Companies { get; set; }
    public List<EmployeeModel> Employees { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }

    public UserResponseDTO() { }

    public UserResponseDTO(long id, Guid uuid, string name, string email, List<RoleModel> roles, List<CompanyModel> companies, List<EmployeeModel> employees, DateTime createdOn, DateTime updatedOn)
    {
        Id = id;
        Uuid = uuid;
        Name = name;
        Email = email;
        Roles = roles;
        Companies = companies;
        Employees = employees;
        CreatedOn = createdOn;
        UpdatedOn = updatedOn;
    }
}