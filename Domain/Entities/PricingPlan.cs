using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class PricingPlan
{
    [Key]
    public int Id { get; set; }
    [Required]
    public double HourlyPricing { get; set; }
    [Required]
    public double DailyPricing { get; set; }
    [Required]
    public int MinimumHours { get; set; }

    [Required]
    public int PricingPlanTypeId { get; set; }
    public PricingPlanType Type { get; set; }
}
