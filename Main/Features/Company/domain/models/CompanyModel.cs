using APPOINTMENT_SERVICE_API.Main.Features.Booking.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Client.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Employee.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Role.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Service.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.User.domain.models;

namespace APPOINTMENT_SERVICE_API.Main.Features.Company.domain.models;

public class CompanyModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public TimeSpan OpeningTime { get; set; }
    public TimeSpan ClosingTime { get; set; }
    public int EmployeesCount { get; set; }
    public ICollection<EmployeeModel> Employees { get; set; } = new List<EmployeeModel>();
    public ICollection<ServiceModel> Services { get; set; } = new List<ServiceModel>();
    public ICollection<ClientModel> Clients { get; set; } = new List<ClientModel>();
    public ICollection<BookingModel> Bookings { get; set; } = new List<BookingModel>();
    public ICollection<UserModel> Users { get; set; } = new List<UserModel>();
    public ICollection<RoleModel> Roles { get; set; } = new List<RoleModel>();
}