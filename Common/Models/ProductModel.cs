using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel.DataAnnotations;

namespace Common.Models;

//TODO: Denna finns för att säkerställa att vi inte använder oss av Entiteter från Databasen i våra vyer.
public class ProductModel
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public double Price { get; set; }

    public List<StoreModel> Stores { get; set; } = new();
}