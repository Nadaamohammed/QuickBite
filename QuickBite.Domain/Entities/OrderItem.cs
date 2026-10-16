using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuickBite.Domain.Entities;

public class OrderItem
{
    public int Id { get; set; }

    [Required, MaxLength(150)]
    public string MenuItemNameSnapshot { get; set; }
    public int Quantity { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal UnitPrice { get; set; }
    [MaxLength(500)]
    public string SpecialInstructions { get; set; } = default!;
    [MaxLength(500)]
    public string CustomizationsSummary { get; set; } = default!;
    // Navigation
    public int OrderId { get; set; }

    public Order Order { get; set; }
    public int MenuItemId { get; set; }

    public MenuItem MenuItem { get; set; }
}
