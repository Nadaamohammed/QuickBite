using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuickBite.Domain.Entities;

public class CartItem
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    [MaxLength(500)]
    public string SpecialInstructions { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal UnitPrice { get; set; }
    // Navigation
    public int CartId { get; set; }

    public Cart Cart { get; set; }
    public int MenuItemId { get; set; }

    public MenuItem MenuItem { get; set; }

    public ICollection<CartItemOption> CartItemOptions { get; set; }
}
