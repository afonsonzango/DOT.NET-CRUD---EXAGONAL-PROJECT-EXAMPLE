using APPOINTMENT_SERVICE_API.Main.Features.Client.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Client.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Client.domain.mappers;

public class ClientMapperProfile : Profile
{
    public ClientMapperProfile()
    {
        CreateMap<ClientEntity, ClientModel>().ReverseMap();
    }
}