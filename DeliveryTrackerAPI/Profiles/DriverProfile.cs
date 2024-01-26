using AutoMapper;
using DeliveryTrackerAPI.DTOS.Requests;
using DeliveryTrackerAPI.DTOS.Response;
using DeliveryTrackerAPI.Data;

namespace DeliveryTrackerAPI.Profiles
{
    public class DriverProfile : Profile
    {
        public DriverProfile() 
        {
            CreateMap<Driver, DriverResponseDto>();
            CreateMap<DriverRequestDto, Driver>();
        }
    }
}
