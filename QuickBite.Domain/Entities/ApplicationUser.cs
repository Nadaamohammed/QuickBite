using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuickBite.Domain.Entities;

public class ApplicationUser  : IdentityUser
{
    [Required, MaxLength(50)]
    public string FirstName { get; set; } = default!;
    [Required, MaxLength(50)]
    public string LastName { get; set; } = default!;
    [MaxLength(500)]
    public string? ProfilePictureUrl { get; set; }
    public DateTime? DataOfBirth { get; set; }
    public int BitPointsBalance { get; set; }
    public string MembershipTier { get; set; } = default!;
    public DateTime MembershipSince { get; set; }
    public DateTime FreeDeliveryValidUntil { get; set; }
    [MaxLength(20)]
    public string TwoFactorPhone { get; set; } = default!;
    public bool SmsOrderUpdatesEnabled { get; set; }
    public bool EmailReceiptsEnabled { get; set; }
    public bool ExclusiveOffersEnabled { get; set; }
    public DateTime LastUpdated { get; set; }

    //relationships
    public ICollection<Address> Addresses { get; set; } = [];
    public ICollection<Order> Orders { get; set; } = [];
    public ICollection<Review> Reviews { get; set; } = [];}
    public ICollection<Notification> Notifications { get; set; } = [];
    public ICollection<Payment> Payments { get; set; } = [];
    public Cart Cart { get; set; }
    public ICollection<UserDietaryPreference> DietaryPreferences { get; set; } = [];


}
