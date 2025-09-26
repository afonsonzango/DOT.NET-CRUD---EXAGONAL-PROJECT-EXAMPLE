using APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.domain.mappers;

public class WorkScheduleMapperProfile : Profile
{
    public WorkScheduleMapperProfile()
    {
        CreateMap<WorkScheduleEntity, WorkScheduleModel>().ReverseMap();
    }
}