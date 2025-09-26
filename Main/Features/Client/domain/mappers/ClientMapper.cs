using APPOINTMENT_SERVICE_API.Main.Features.Client.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Client.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Client.domain.mappers;

public class ClientMapper
{
    private readonly IMapper _mapper;
    
    public ClientMapper(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public ClientModel ToModel(ClientEntity entity)
    {
        return _mapper.Map<ClientModel>(entity);
    }

    public ClientEntity ToEntity(ClientModel model)
    {
        return _mapper.Map<ClientEntity>(model);
    }
}