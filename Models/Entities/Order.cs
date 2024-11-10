using System.ComponentModel.DataAnnotations;

public class Order
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string UserId { get; set; } = null!;

    [Required]
    [Range(0, 100000)]
    public decimal TotalAmount { get; set; }

    [Required]
    public DateTime Date { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; }
}
