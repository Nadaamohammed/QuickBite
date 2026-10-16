using System.ComponentModel.DataAnnotations.Schema;

namespace QuickBite.Domain.Entities
{
    public class OrderPromoCode
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal DiscountApplied { get; set; }
        // Navigation
        public int OrderId { get; set; }

        public Order Order { get; set; }
        public int PromoCodeId { get; set; }

        public PromoCode PromoCode { get; set; }
    }
}