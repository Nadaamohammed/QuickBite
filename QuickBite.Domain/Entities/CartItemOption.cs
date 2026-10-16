using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickBite.Domain.Entities;

public class CartItemOption
{
    public int Id { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal AdditionalPrice { get; set; }
    // Navigation
    public int CartItemId { get; set; }

    public CartItem CartItem { get; set; }
    public int OptionId { get; set; }

    public Option Option { get; set; }
}