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
        private readonly IMapper _mapper;

        public SpotListingController(IParkingRepository parkingContext, IMapper mapper)
		{
            _parkingContext = parkingContext;
            _mapper = mapper;
		}
        public IActionResult Total()
        {
            var result = _parkingContext.GetParkingSpots();
            var parkingSpots = _mapper.Map<IEnumerable<ParkingSpots>>(result);
            return View(parkingSpots.First());
        }
    }
}