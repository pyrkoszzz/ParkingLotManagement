using AutoMapper;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;
public class PricingPlanController : Controller
{
    private readonly IPricingPlanRepository pricingPlanRepository;
    private readonly IMapper mapper;

    public PricingPlanController(IPricingPlanRepository pricingPlanRepository, IMapper mapper)
    {
        this.pricingPlanRepository = pricingPlanRepository;
        this.mapper = mapper;
    }
    public IActionResult Index()
    {
        return View(mapper.Map<IEnumerable<PricingPlan>>(pricingPlanRepository.GetPricingPlans()));
    }

    public IActionResult ViewPricingPlanDetails(int id)
    {
        return View(mapper.Map<PricingPlan>(pricingPlanRepository.GetPricingPlanById(id)));
    }
}
