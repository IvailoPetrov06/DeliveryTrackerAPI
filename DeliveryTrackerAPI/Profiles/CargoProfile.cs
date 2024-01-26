using AutoMapper;
using DeliveryTrackerAPI.Data;
using DeliveryTrackerAPI.DTOS.Requests;
using DeliveryTrackerAPI.DTOS.Response;

namespace DeliveryTrackerAPI.Profiles
{
    public class CargoProfile : Profile
    {
        public CargoProfile()
        {
            CreateMap<Cargo, CargoResponseDto>();
            CreateMap<CargoRequestDto, Cargo>();
        }
    }
}
