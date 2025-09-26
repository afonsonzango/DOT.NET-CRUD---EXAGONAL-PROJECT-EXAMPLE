using APPOINTMENT_SERVICE_API.Main.Features.Service.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Service.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Service.domain.mappers;

public class ServiceMapper
{
    private readonly IMapper _mapper;
    
    public ServiceMapper(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public ServiceModel ToModel(ServiceEntity entity)
    {
        return _mapper.Map<ServiceModel>(entity);
    }

    public ServiceEntity ToEntity(ServiceModel model)
    {
        return _mapper.Map<ServiceEntity>(model);
    }
}