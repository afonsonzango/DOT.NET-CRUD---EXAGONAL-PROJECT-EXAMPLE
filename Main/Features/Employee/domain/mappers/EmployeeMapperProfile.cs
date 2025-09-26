using APPOINTMENT_SERVICE_API.Main.Features.Employee.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Employee.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Employee.domain.mappers;

public class EmployeeMapperProfile : Profile
{
    public EmployeeMapperProfile()
    {
        CreateMap<EmployeeEntity, EmployeeModel>().ReverseMap();
    }
}