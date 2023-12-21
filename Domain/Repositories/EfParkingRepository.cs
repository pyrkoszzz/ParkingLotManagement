using Domain.Data;
using Domain.Entities;

namespace Domain.Repositories
{
	public class EfParkingRepository : IParkingRepository
	{
		private readonly ApplicationDbContext _context;

		public EfParkingRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public ParkingSpot GetParkingSpots()
		{
			return _context.ParkingSpots.ToList().First();
		}

		public void UpdateParkingSpots(int TotalSpots)
		{
			_context.ParkingSpots.ToList().First().TotalSpots = TotalSpots;
			_context.SaveChanges();
		}
	}
}