using System.ComponentModel.DataAnnotations;

public class OrderItem
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int ProductId { get; set; }

    public Product Product { get; set; }

    [Required]
    [Range(1, 100)]
    public int Quantity { get; set; }
}
