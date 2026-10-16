using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuickBite.Domain.Entities;

public class DietaryPreference
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string Name { get; set; }
    [MaxLength(50)]
    public string Category { get; set; }
    public ICollection<UserDietaryPreference> UserPreferences { get; set; }
}
