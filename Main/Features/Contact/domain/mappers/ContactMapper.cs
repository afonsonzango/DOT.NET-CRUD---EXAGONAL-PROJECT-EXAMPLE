using APPOINTMENT_SERVICE_API.Main.Features.Contact.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Contact.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Contact.domain.mappers;

public class ContactMapper
{
    private readonly IMapper _mapper;
    
    public ContactMapper(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public ContactModel ToModel(ContactEntity entity)
    {
        return _mapper.Map<ContactModel>(entity);
    }

    public ContactEntity ToEntity(ContactModel model)
    {
        return _mapper.Map<ContactEntity>(model);
    }
}