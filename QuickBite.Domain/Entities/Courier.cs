using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickBite.Domain.Entities
{
    public class Courier
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string FullName { get; set; } = default!;
        [Phone, MaxLength(20)]
        public string PhoneNumber { get; set; } = default!;
        [MaxLength(500)]
        public string? ProfilePhotoUrl { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public decimal Rating { get; set; }
        public bool IsActive { get; set; }
        // Navigation
        public ICollection<Delivery> Deliveries { get; set; }
    }
}