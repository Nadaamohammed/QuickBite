using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuickBite.Domain.Entities;

public class Notification
{
    public int Id { get; set; }
    
    [Required, MaxLength(50)]
    public string Type { get; set; } = default!;
    [Required, MaxLength(200)]
    public string Title { get; set; } = default!;
    [MaxLength(1000)]
    public string Body { get; set; } = default!;
    public bool IsRead { get; set; }
    public DateTime SentAt { get; set; }
    // Navigation
    public int UserId { get; set; }

    public ApplicationUser User { get; set; }
   
}
