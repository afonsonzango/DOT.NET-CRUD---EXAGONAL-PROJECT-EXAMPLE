using APPOINTMENT_SERVICE_API.Main.Features.Role.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Role.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Role.domain.mappers;

public class RoleMapperProfile : Profile
{
    public RoleMapperProfile()
    {
        CreateMap<RoleEntity, RoleModel>().ReverseMap();
    }
}