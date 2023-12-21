using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Subscriber
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Key]
    public int IdCardNumber { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public int PhoneNumber { get; set; }
    [Required]
    public DateTime Birthday { get; set; }
    [Required]
    public string PlateNumber { get; set; }
    public bool IsDeleted { get; set; }

    public int SubscriptionId { get; set; }
    public Subscription Subscription { get; set; }
}
