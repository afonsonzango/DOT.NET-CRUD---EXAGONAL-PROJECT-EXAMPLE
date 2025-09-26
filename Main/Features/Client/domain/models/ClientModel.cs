using APPOINTMENT_SERVICE_API.Main.Features.Address.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Booking.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Company.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Contact.domain.models;

namespace APPOINTMENT_SERVICE_API.Main.Features.Client.domain.models;

public class ClientModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public CompanyModel Company { get; set; }
    public ICollection<AddressModel> Addresses { get; set; } = new List<AddressModel>();
    public ICollection<ContactModel> Contacts { get; set; } = new List<ContactModel>();
    public ICollection<BookingModel> Bookings { get; set; } = new List<BookingModel>();
}