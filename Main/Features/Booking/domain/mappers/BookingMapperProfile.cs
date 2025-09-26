using APPOINTMENT_SERVICE_API.Main.Features.Booking.domain.models;
using APPOINTMENT_SERVICE_API.Main.Features.Booking.infrastructure.entity;
using AutoMapper;

namespace APPOINTMENT_SERVICE_API.Main.Features.Booking.domain.mappers;

public class BookingMapperProfile : Profile
{
    public BookingMapperProfile()
    {
        CreateMap<BookingEntity, BookingModel>().ReverseMap();
    }
}