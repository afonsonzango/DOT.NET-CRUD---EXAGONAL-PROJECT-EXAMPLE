using APPOINTMENT_SERVICE_API.Main.Features.Company.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.User.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.domain.models;

namespace APPOINTMENT_SERVICE_API.Main.Features.Employee.domain.models;

public class EmployeeModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public UserModel User { get; set; }
    public CompanyModel Company { get; set; }
    public DateTime HiredAt { get; set; }
    public bool Active { get; set; }
    public ICollection<WorkScheduleModel> WorkSchedules { get; set; } = new List<WorkScheduleModel>();
}