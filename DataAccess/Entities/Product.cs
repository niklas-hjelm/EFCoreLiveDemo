using System.ComponentModel.DataAnnotations;
using Common.Interfaces;

namespace DataAccess.Entities;

public class Product : IEntity<int>
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public double Price { get; set; }

    public List<Store> Stores { get; set; } = new();
}