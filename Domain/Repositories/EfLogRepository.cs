using Domain.Data;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
	public class EfLogRepository : IEfLogRepository
	{
		private readonly ApplicationDbContext _context;

		public EfLogRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Log> GetAllLogs()
		{
			return _context.Logs.ToList();
		}

		public void CreateLog(Log log)
		{
			_context.Logs.Add(log);
		}
	}
}
