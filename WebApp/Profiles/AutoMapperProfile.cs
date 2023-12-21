using AutoMapper;
using Domain.Entities;
using WebApp.Models;

namespace WebApp.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ParkingSpot, ParkingSpots>().ReverseMap();
            CreateMap<Domain.Entities.PricingPlan, Models.PricingPlan>().ReverseMap();
            CreateMap<Domain.Entities.PricingPlanType, Models.PricingPlanType>().ReverseMap();
        }
    }
}
