using AutoMapper;
using DeliveryTrackerAPI.Data;
using DeliveryTrackerAPI.DTOS.Requests;
using DeliveryTrackerAPI.DTOS.Response;

namespace DeliveryTrackerAPI.Profiles
{
    public class DeliveryProfile : Profile
    {
        public DeliveryProfile()
        {
            CreateMap<Delivery, DeliveryResponseDto>();
            CreateMap<DeliveryRequestDto, Delivery>();
        }
    }
}
