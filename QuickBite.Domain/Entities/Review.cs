using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuickBite.Domain.Entities;

public class Review
{    public int Id { get; set; }
  
    [Range(1, 5)]
    public int StarRating { get; set; }
    [MaxLength(1000)]
    public string Comment { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    // Navigation
    public int UserId { get; set; }

    public ApplicationUser User { get; set; }
    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
}
