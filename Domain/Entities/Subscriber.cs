namespace Domain.Entities;

public class Subscriber
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int IdCardNumber { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public DateTime Birthday { get; set; }
    public string PlateNumber { get; set; }
    public bool IsDeleted { get; set; }
}
