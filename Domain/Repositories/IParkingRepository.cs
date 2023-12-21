using Domain.Entities;

namespace Domain.Repositories
{
	public interface IParkingRepository
	{
		public IEnumerable<ParkingSpot> GetParkingSpots();
	}
}