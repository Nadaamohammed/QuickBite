using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickBite.Domain.Entities;

public class UserDietaryPreference
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }

    public ApplicationUser User { get; set; }
    public int DietaryPreferenceId { get; set; }

    public DietaryPreference DietaryPreference { get; set; }
}