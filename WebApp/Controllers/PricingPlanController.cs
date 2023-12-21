using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;
public class PricingPlanController : Controller
{
    private readonly IPricingPlanRepository pricingPlanRepository;

    public PricingPlanController(IPricingPlanRepository pricingPlanRepository)
    {
        this.pricingPlanRepository = pricingPlanRepository;
    }

    public IActionResult Index()
    {
        return View();
    }
}
