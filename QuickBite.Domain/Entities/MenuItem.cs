using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickBite.Domain.Entities;

public class MenuItem
{
    public int Id { get; set; }
    [Required, MaxLength(150)]
    public string Name { get; set; }
    [MaxLength(500)]
    public string Description { get; set; }
    [MaxLength(500)]
    public string ImageUrl { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal BasePrice { get; set; }
    public bool IsAvailable { get; set; } = true;
    public bool IsTrending { get; set; }
    public bool IsChefSelection { get; set; }
    [MaxLength(100)]
    public string DietaryTag { get; set; }
    [Column(TypeName = "decimal(3,2)")]
    public decimal? Rating { get; set; }
    public int? ReviewCount { get; set; }
    public int CalorieCount { get; set; }

    //
    public int MenuCategoryId { get; set; }
    public MenuCategory MenuCategory { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; } = [];



}