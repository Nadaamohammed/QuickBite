using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuickBite.Domain.Entities;

public class PromoCode
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string Code { get; set; } = default!;
    public string Description { get; set; } = default!;

    [Column(TypeName = "decimal(10,2)")]
    public decimal DiscountAmount { get; set; }
    public DateTime ExpiryDate { get; set; }
    public bool IsActive { get; set; } = true;
}
