using DataAccess.Entities;

namespace DataAccess.Services;

public class StoreRepository
{
    private readonly ProductContext _context;

    public StoreRepository(ProductContext context)
    {
        _context = context;
    }

    public List<StoreModel> GetAllStores()
    {
        return _context.Stores.Select(
                       store => new StoreModel
                       {
                           Id = store.Id,
                           Name = store.Name,
                           Inventory = store.Products.Select(
                                       product => new ProductModel
                                       {
                                           Id = product.Id,
                                           Name = product.Name,
                                           Description = product.Description,
                                           Price = product.Price
                                       }).ToList()
                       }).ToList();
    }

    public StoreModel GetStoreById(int id)
    {
        var store = _context.Stores.Find(id);
        return new StoreModel
        {
            Id = store.Id,
            Name = store.Name,
            Inventory = store.Products.Select(
                                          product => new ProductModel
                                          {
                                              Id = product.Id,
                                              Name = product.Name,
                                              Description = product.Description,
                                              Price = product.Price
                                          }).ToList()
        };
    }

    public void AddStore(StoreModel store)
    {
        var a = _context.Stores.Add(
            new Store()
            {
                Name = store.Name,
                Products = store.Inventory.Select(
                                       product => new Product
                                       {
                                           Name = product.Name,
                                           Description = product.Description,
                                           Price = product.Price
                                       }).ToList()
            });
        _context.SaveChanges();
    }

    public bool UpdateStore(StoreModel store)
    {
        var existingStore = _context.Stores.Find(store.Id);
        if (existingStore is null) return false;

        existingStore.Name = store.Name;
        existingStore.Products = store.Inventory.Select(
                                                  product => new Product
                                                  {
                                                      Name = product.Name,
                                                      Description = product.Description,
                                                      Price = product.Price
                                                  }).ToList();

        _context.SaveChanges();
        return true;
    }

    public void DeleteStore(int id)
    {
        var store = _context.Stores.Find(id);
        if (store is null) return;

        _context.Stores.Remove(store);
        _context.SaveChanges();
    }
}