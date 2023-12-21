using AutoMapper;
using Domain.Data;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class SpotListingController : Controller
    {
        private readonly IParkingRepository _parkingContext;
        private readonly ISubscriptionRepository _subscriptionRepository;
        private readonly IMapper _mapper;

        public SpotListingController(IParkingRepository parkingContext, ISubscriptionRepository subsctriptionContext, IMapper mapper)
		{
            _parkingContext = parkingContext;
            _subscriptionRepository = subsctriptionContext;
            _mapper = mapper;
		}
        public IActionResult Total()
        {
            var all = _parkingContext.GetParkingSpots().TotalSpots;
            var reserved = _subscriptionRepository.GetAllSubscriptions().Count();
            var parkingSpots = new ParkingSpots() 
            { 
                TotalSpots = all,
                ReservedSpots = reserved,
                RegularSpots = all - reserved
            };
            return View(parkingSpots);
        }

        [HttpPost]
        public IActionResult Total(ParkingSpots parkingSpots)
        {
            var newParkingSpots = new ParkingSpots()
            {
                TotalSpots = parkingSpots.TotalSpots,
                ReservedSpots = parkingSpots.ReservedSpots,
                RegularSpots = parkingSpots.TotalSpots - parkingSpots.ReservedSpots
            };
            _parkingContext.UpdateParkingSpots(parkingSpots.TotalSpots);
            return View(newParkingSpots);
        }
    }
}