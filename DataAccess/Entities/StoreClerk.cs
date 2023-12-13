using Common.Interfaces;

namespace DataAccess.Entities;

public class StoreClerk : IEntity<string>
{
    public string Id { get; set; }
    public string Name { get; set; }
    public Store Store { get; set; }
}