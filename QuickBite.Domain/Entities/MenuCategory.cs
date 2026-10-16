using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuickBite.Domain.Entities;

public class MenuCategory
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string Name { get; set; } = default!;
    [MaxLength(200)]
    public string Description { get; set; } = default!;
    public int DisplayOrder { get; set; }
    // Navigation
    public int RestaurantId { get; set; }

    public Restaurant Restaurant { get; set; }
    public ICollection<MenuItem> MenuItems { get; set; }
}
