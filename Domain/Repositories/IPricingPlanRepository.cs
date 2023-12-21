using Domain.Entities;

namespace Domain.Repositories;

public interface IPricingPlanRepository
{
    IEnumerable<PricingPlan> GetPricingPlans();
    PricingPlan GetPricingPlanById(int id);
    void UpdatePricingPlan(PricingPlan pricingPlan);
}
