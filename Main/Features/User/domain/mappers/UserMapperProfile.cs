using APPOINTMENT_SERVICE_API.Main.Features.User.application.dtos;
using APPOINTMENT_SERVICE_API.Main.Features.User.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.User.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.User.domain.mappers;

public class UserMapperProfile : Profile
{
    public UserMapperProfile()
    {
        CreateMap<UserEntity, UserModel>().ReverseMap();
        CreateMap<UserModel, UserResponseDTO>().ReverseMap();
    }
}