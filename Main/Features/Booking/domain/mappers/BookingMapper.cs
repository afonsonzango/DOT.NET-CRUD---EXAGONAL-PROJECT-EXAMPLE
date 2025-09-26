using APPOINTMENT_SERVICE_API.Main.Features.Booking.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Booking.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Booking.domain.mappers;

public class BookingMapper
{
    private readonly IMapper _mapper;
    
    public BookingMapper(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public BookingModel ToModel(BookingEntity entity)
    {
        return _mapper.Map<BookingModel>(entity);
    }

    public BookingEntity ToEntity(BookingModel model)
    {
        return _mapper.Map<BookingEntity>(model);
    }
}