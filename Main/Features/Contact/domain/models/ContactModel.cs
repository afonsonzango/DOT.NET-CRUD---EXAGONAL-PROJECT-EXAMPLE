using APPOINTMENT_SERVICE_API.Main.Features.Client.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Contact.domain.enums;

namespace APPOINTMENT_SERVICE_API.Main.Features.Contact.domain.models;

public class ContactModel
{
    public string Value { get; set; }
    public ContactTypeEnum type { get; set; }
    public ClientModel Client { get; set; }
}