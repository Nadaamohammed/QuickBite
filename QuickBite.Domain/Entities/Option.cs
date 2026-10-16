using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickBite.Domain.Entities
{
    public class Option
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = default!;
        [MaxLength(255)]
        public string Description { get; set; } = default!;
        [Column(TypeName = "decimal(10,2)")]
        public decimal AdditionalPrice { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsDefault { get; set; }
        public bool IsRecommended { get; set; }

        //Navigation
        public int CustomizationGroupId { get; set; }
        public CustomizationGroup CustomizationGroup { get; set; } = default!;
    }
}