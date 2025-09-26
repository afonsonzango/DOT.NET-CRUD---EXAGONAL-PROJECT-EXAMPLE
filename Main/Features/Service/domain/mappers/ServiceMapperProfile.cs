using APPOINTMENT_SERVICE_API.Main.Features.Service.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Service.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Service.domain.mappers;

public class ServiceMapperProfile : Profile
{
    public ServiceMapperProfile()
    {
        CreateMap<ServiceEntity, ServiceModel>().ReverseMap();
    }
}