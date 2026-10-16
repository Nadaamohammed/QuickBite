using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBite.Domain.Entities;

public class Cart
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    //Navigation properties
    public int UserId { get; set; }
    public ApplicationUser User { get; set; }
    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
    public ICollection<CartItem> CartItems { get; set; }
}
