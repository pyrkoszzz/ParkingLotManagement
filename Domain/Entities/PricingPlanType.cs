using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class PricingPlanType
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public List<PricingPlan> pricingPlans { get; set; }
}
