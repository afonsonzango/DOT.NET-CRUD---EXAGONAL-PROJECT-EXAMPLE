using APPOINTMENT_SERVICE_API.Main.Features.Booking.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Company.domain.models;

namespace APPOINTMENT_SERVICE_API.Main.Features.Service.domain.models;

public class ServiceModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int DurationMinutes { get; set; }
    public int EmployeesRequired { get; set; }
    public CompanyModel Company { get; set; }
    public ICollection<BookingModel> Bookings { get; set; } = new List<BookingModel>();
}