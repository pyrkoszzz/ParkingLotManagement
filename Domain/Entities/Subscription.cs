namespace Domain.Entities;

public class Subscription
{
    public int Id { get; set; }
    public int Code { get; set; }
    public int SubscriberId { get; set; }
    public double Price { get; set; }
    public double DiscountValue { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsDeleted { get; set; }
}
