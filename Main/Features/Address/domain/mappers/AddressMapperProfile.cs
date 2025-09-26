using APPOINTMENT_SERVICE_API.Main.Features.Address.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Address.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Address.domain.mappers;

public class AddressMapperProfile : Profile
{
    public AddressMapperProfile()
    {
        CreateMap<AddressEntity, AddressModel>().ReverseMap();
    }
}