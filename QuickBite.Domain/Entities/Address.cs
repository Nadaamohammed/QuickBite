using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuickBite.Domain.Entities;

public class Address 
{
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string Label { get; set; } = default!;
    [Required, MaxLength(100)]
    public string StreetLine1 { get; set; } = default!;
    [Required, MaxLength(50)]
    public string City { get; set; } = default!;
    [Required, MaxLength(50)]
    public string State { get; set; } = default!;
    [Required, MaxLength(20)]
    public string PostalCode { get; set; } = default!;
    [Required, MaxLength(50)]
    public string Country { get; set; } = default!;
    public bool IsDefault { get; set; }
    [MaxLength(300)]
    public string? DropoffInstructions { get; set; }


    //relation
    public int UserId { get; set; }
    public ApplicationUser User { get; set; } = default!;
    public ICollection<Order> Orders { get; set; } = [];
}
