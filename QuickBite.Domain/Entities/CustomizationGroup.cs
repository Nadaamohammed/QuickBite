using System.ComponentModel.DataAnnotations;

namespace QuickBite.Domain.Entities
{
    public class CustomizationGroup
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = default!;
        [MaxLength(255)]
        public string SelectionType { get; set; } = default!;
        public bool AllowMultipleSelections { get; set; }
        public int DisplayOrder { get; set; }

        //Navigation
        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; } = default!;
    }
}