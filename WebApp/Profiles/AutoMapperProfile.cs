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
            CreateMap<Domain.Entities.PricingPlan, Models.PricingPlan>().ReverseMap()
                .ForMember(plan => plan.Type, opt => opt.MapFrom(src => src.Type));
            CreateMap<Domain.Entities.PricingPlanType, Models.PricingPlanType>().ReverseMap();
            CreateMap<Domain.Entities.Subscription, Models.Subscription>().ReverseMap();
            CreateMap<Domain.Entities.Log, Models.Log>().ReverseMap();
        }
    }
}
