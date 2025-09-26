using APPOINTMENT_SERVICE_API.Main.Features.Booking.domain.enums;
using APPOINTMENT_SERVICE_API.Main.Features.Client.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Company.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Service.domain.models;

namespace APPOINTMENT_SERVICE_API.Main.Features.Booking.domain.models;

public class BookingModel
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public BookingStatusEnum Status { get; set; }
    public ClientModel Client { get; set; }
    public ServiceModel Service { get; set; }
    public CompanyModel Company { get; set; }
}