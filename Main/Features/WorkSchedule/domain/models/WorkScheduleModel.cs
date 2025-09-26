using APPOINTMENT_SERVICE_API.Main.Features.Company.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Employee.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.domain.enums;

namespace APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.domain.models;

public class WorkScheduleModel
{
    public DateTime WorkDate { get; set; }
    public WeekDayEnum WeekDay { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public CompanyModel Company { get; set; }
    public ICollection<EmployeeModel> Employees { get; set; } = new List<EmployeeModel>();
}