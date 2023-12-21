namespace Domain.Entities;

public class Log
{
    public int Id { get; set; }
    public int Code { get; set; }
    public int SubscriptionId { get; set; }
    public DateTime CheckInTime { get; set; }
    public DateTime CheckOutTime { get; set; }
    public double Price { get; set; }
}
