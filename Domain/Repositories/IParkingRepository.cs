using Domain.Entities;

namespace Domain.Repositories
{
	public interface IParkingRepository
	{
		public ParkingSpot GetParkingSpots();
		public void UpdateParkingSpots(int TotalSpots);
	}
}