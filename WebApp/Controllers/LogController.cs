using AutoMapper;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
	public class LogController : Controller
	{
		private readonly IEfLogRepository _logRepository;
		private readonly IMapper _mapper;

		public LogController(IEfLogRepository logRepository, IMapper mapper)
		{
			_logRepository = logRepository;
			_mapper = mapper;
		}
		public IActionResult ListAll()
		{
			var logs = _logRepository.GetAllLogs();
			return View(_mapper.Map<IEnumerable<Log>>(logs));
		}
	}
}
