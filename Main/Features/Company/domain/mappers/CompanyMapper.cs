using APPOINTMENT_SERVICE_API.Main.Features.Company.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Company.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Company.domain.mappers;

public class CompanyMapper
{
    private readonly IMapper _mapper;
    
    public CompanyMapper(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public CompanyModel ToModel(CompanyEntity entity)
    {
        return _mapper.Map<CompanyModel>(entity);
    }

    public CompanyEntity ToEntity(CompanyModel model)
    {
        return _mapper.Map<CompanyEntity>(model);
    }
}