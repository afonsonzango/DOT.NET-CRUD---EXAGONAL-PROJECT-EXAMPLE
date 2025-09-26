using APPOINTMENT_SERVICE_API.Main.Features.Contact.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Contact.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Contact.domain.mappers;

public class ContactMapperProfile : Profile
{
    public ContactMapperProfile()
    {
        CreateMap<ContactEntity, ContactModel>().ReverseMap();
    }
}