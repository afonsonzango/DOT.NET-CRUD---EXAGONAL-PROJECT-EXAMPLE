using APPOINTMENT_SERVICE_API.Main.Features.Client.domain.models;
using APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Models;

namespace APPOINTMENT_SERVICE_API.Main.Features.Address.domain.models;

public class AddressModel : BaseModel
{
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public string? Street { get; set; }
    public string? Country { get; set; }
    public ClientModel Client { get; set; }
}