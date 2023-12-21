using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Log
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int Code { get; set; }
    [Required]
    public DateTime CheckInTime { get; set; }
    [Required]
    public DateTime CheckOutTime { get; set; }
    [Required]
    public double Price { get; set; }

    public int SubscriptionId { get; set; }
    public Subscription Subscription { get; set; }
}
