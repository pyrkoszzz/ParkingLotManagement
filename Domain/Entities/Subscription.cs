using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Subscription
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int Code { get; set; }
    [Required]
    public double Price { get; set; }
    [Required]
    public double DiscountValue { get; set; }
    [Required]
    public DateTime StartDate { get; set; }
    [Required]
    public DateTime EndDate { get; set; }
    [Required]
    public bool IsDeleted { get; set; }

    [Required]
    public int SubscriberId { get; set; }
    public Subscriber Subscriber { get; set; }

/*    public int LogId { get; set; }
    public Log Log { get; set; }*/
}
