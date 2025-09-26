using APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.WorkSchedule.domain.mappers;

public class WorkScheduleMapper
{
    private readonly IMapper _mapper;
    
    public WorkScheduleMapper(IMapper mapper)
    {
        _mapper = mapper;
    }

    public WorkScheduleModel ToModel(WorkScheduleEntity entity)
    {
        return _mapper.Map<WorkScheduleModel>(entity);
    }

    public WorkScheduleEntity ToEntity(WorkScheduleModel model)
    {
        return _mapper.Map<WorkScheduleEntity>(model);
    }
}