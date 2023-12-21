using Domain.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories;

public class PricingPlanRepository : IPricingPlanRepository
{
    private readonly ApplicationDbContext context;

    public PricingPlanRepository(ApplicationDbContext context)
    {
        this.context = context;
    }

    public PricingPlan GetPricingPlanById(int id)
    {
        return context.PricingPlans.Include(p => p.Type).FirstOrDefault(p => p.Id == id);
    }

    public IEnumerable<PricingPlan> GetPricingPlans()
    {
        return context.PricingPlans.Include(p=>p.Type);
    }

    public void UpdatePricingPlan(PricingPlan pricingPlan)
    {
        context.PricingPlans.Update(pricingPlan);
    }
}
