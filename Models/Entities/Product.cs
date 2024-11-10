﻿using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [MaxLength(500)]
    public string Description { get; set; }

    [Required]
    [Range(0, 10000)]
    public decimal Price { get; set; }

    [Required]
    public int CategoryId { get; set; }

    public Category Category { get; set; }
}
