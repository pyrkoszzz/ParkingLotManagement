using Domain.Entities;

namespace Domain.Repositories
{
	public interface IEfLogRepository
	{
		void CreateLog(Log log);
		IEnumerable<Log> GetAllLogs();
	}
}