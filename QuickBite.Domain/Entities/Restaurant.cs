using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuickBite.Domain.Entities;

public class Restaurant
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = default!;
    [MaxLength(255)]
    public string Description { get; set; } = default!;
    [MaxLength(255)]
    public string? LogoUrl { get; set; }
    [MaxLength(255)]
    public string? ImageUrl { get; set; }
    [MaxLength(100)]
    public string Cuisine { get; set; } = default!;
    [Column(TypeName = "decimal(3,2)")]
    public decimal Rating { get; set; }
    public int ReviewCount { get; set; }
    [MaxLength(50)]
    public string EstimatedDeliveryTime { get; set; } // in minutes
    [Column(TypeName = "decimal(10,2)")]
    public decimal DeliveryFee { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal MinimumOrderAmount { get; set; }
    public double DistanceMiles { get; set; }

    public bool IsOpen { get; set; }
    public bool IsFeatured { get; set; }
    // Address
    [MaxLength(255)]
    public string StreetAddress { get; set; }
    [MaxLength(100)]
    public string City { get; set; }
    [MaxLength(50)]
    public string State { get; set; }

    public ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
