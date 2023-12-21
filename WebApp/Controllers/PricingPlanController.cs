using AutoMapper;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

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
    public IActionResult PricingPlanList()
    {
        return View(mapper.Map<IEnumerable<Models.PricingPlan>>(pricingPlanRepository.GetPricingPlans()));
    }

    public IActionResult EditPricingPlan(int id)
    {
        return View(mapper.Map<Models.PricingPlan>(pricingPlanRepository.GetPricingPlanById(id)));
    }

    [HttpPost]
    public IActionResult EditPricingPlan(Models.PricingPlan pricingPlan)
    {
        pricingPlanRepository.UpdatePricingPlan(mapper.Map<Domain.Entities.PricingPlan>(pricingPlan));

        return View("PricingPlanList", mapper.Map<IEnumerable<Models.PricingPlan>>(pricingPlanRepository.GetPricingPlans()));
    }
}
