namespace Common.Models;

//TODO: Denna finns för att säkerställa att vi inte använder oss av Entiteter från Databasen i våra vyer.
public class StoreModel
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public List<ProductModel> Inventory { get; set; } = new();
}