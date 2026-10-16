using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuickBite.Domain.Entities;

public class Category
{
    public int Id { get; set; }
    [MaxLength(80)]
    public string Name { get; set; } = default!;
    [MaxLength(255)]
    public string? IconUrl { get; set; }
    public int DisplayOrder { get; set; }
    public int ItemCount { get; set; }
}
