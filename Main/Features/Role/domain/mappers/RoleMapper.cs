using APPOINTMENT_SERVICE_API.Main.Features.Role.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Role.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Role.domain.mappers;

public class RoleMapper
{
    private readonly IMapper _mapper;
    
    public RoleMapper(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public RoleModel ToModel(RoleEntity entity)
    {
        return _mapper.Map<RoleModel>(entity);
    }

    public RoleEntity ToEntity(RoleModel model)
    {
        return _mapper.Map<RoleEntity>(model);
    }
}