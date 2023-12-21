using Domain.Entities;

namespace Domain.Repositories
{
	public interface IParkingRepository
	{
		public ParkingSpot GetParkingSpots();
	}
}