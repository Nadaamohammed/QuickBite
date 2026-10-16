using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace QuickBite.Domain.Entities
{
    public class Delivery
    {
        public int Id { get; set; }
        
        [MaxLength(30)]
        public DeliveryStatus Status { get; set; }
        public DateTime? PickedUpAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
        public int EstimatedMinutes { get; set; }
        [MaxLength(500)]
        public string? LiveTrackingUrl { get; set; }
        [MaxLength(10)]
        public string DeliveryVerificationCode { get; set; } = default!;
        // Navigation
        public int OrderId { get; set; }

        public Order Order { get; set; }
        public int? CourierId { get; set; }

        public Courier Courier { get; set; }
    }
}