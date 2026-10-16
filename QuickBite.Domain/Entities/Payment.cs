using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuickBite.Domain.Entities;

public class Payment
{
    public int Id { get; set; }
    public PaymentType PaymentType { get; set; } = default!;

    [MaxLength(4)]
    public string CardLastFour { get; set; }
    [MaxLength(10)]
    public string CardBrand { get; set; }
    [MaxLength(7)]
    public string ExpirationDate { get; set; }   // MM/YY
    [MaxLength(20)]
    public string PostalCode { get; set; }
    public bool IsSavedForReorder { get; set; }
    public bool IsDefault { get; set; }
    [MaxLength(255)]
    public string StripePaymentMethodId { get; set; }

    //relation
    public int UserId { get; set; }
    public ApplicationUser User { get; set; } = default!;
    public ICollection<Order> Orders { get; set; } = [];

}
