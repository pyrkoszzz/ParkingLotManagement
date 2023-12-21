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
            CreateMap<Domain.Entities.Subscription, Models.Subscription>().ReverseMap();
        }
    }
}
