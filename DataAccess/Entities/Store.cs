namespace DataAccess.Entities;

public class Store
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public List<Product> Products { get; set; } = new();
}