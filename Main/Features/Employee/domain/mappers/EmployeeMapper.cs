using APPOINTMENT_SERVICE_API.Main.Features.Employee.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Employee.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Employee.domain.mappers;

public class EmployeeMapper
{
    private readonly IMapper _mapper;
    
    public EmployeeMapper(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public EmployeeModel ToModel(EmployeeEntity entity)
    {
        return _mapper.Map<EmployeeModel>(entity);
    }

    public EmployeeEntity ToEntity(EmployeeModel model)
    {
        return _mapper.Map<EmployeeEntity>(model);
    }
}