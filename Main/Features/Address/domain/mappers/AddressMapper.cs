using APPOINTMENT_SERVICE_API.Main.Features.Address.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Address.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Address.domain.mappers;

public class AddressMapper
{
    private readonly IMapper _mapper;

    public AddressMapper(IMapper mapper)
    {
        _mapper = mapper;
    }

    public AddressModel ToModel(AddressEntity entity)
    {
        return _mapper.Map<AddressModel>(entity);
    }

    public AddressEntity ToEntity(AddressModel model)
    {
        return _mapper.Map<AddressEntity>(model);
    }
}