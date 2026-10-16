using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuickBite.Domain.Entities;

public class Order
{
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string OrderNumber { get; set; }
    [Required, MaxLength(30)]
    public OrderStatus Status { get; set; }
    [Required, MaxLength(30)]
    public DeliveryType DeliveryType { get; set; }
    public DateTime? ScheduledDeliveryTime { get; set; }
    [MaxLength(500)]
    public string DropOffInstructions { get; set; } = string.Empty;
    [Column(TypeName = "decimal(10,2)")]
    public decimal ItemsSubtotal { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal DeliveryFee { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal TaxesAndRegulatoryFees { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal CourierTip { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal DiscountAmount { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal TotalAmount { get; set; }
    public DateTime PlacedAt { get; set; }
    public DateTime? EstimatedDeliveryAt { get; set; }
    public DateTime? DeliveredAt { get; set; }
    // Navigation
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
    public int DeliveryAddressId { get; set; }
    public Address DeliveryAddress { get; set; }
    public int? PaymentId { get; set; }
    public Payment Payment { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; } = [];
    public ICollection<OrderPromoCode> PromoCodes { get; set; } = [];
    public int? DeliveryId { get; set; }
    public Delivery Delivery { get; set; }
}
