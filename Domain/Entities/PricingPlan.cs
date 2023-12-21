namespace Domain.Entities;

public class PricingPlan
{
    public int Id { get; set; }
    public double HourlyPricing { get; set; }
    public double DailyPricing { get; set; }
    public int MinimumHours { get; set; }
    public PricingPlanType Type { get; set; }
}
