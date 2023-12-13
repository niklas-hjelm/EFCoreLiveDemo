using Common.Interfaces;
using DataAccess.Entities;

namespace DataAccess.Services;

public class StoreClerkRepository : IRepository<StoreClerk, string>
{
    private readonly ProductContext _context;

    public StoreClerkRepository(ProductContext context)
    {
        _context = context;
    }

    public StoreClerk GetById(string id)
    {
        return _context.StoreClerks.Find(id);
    }

    public IEnumerable<StoreClerk> GetAll()
    {
        return _context.StoreClerks;
    }

    public void Add(StoreClerk entity)
    {
        _context.StoreClerks.Add(entity);
        _context.SaveChanges();
    }

    public void Update(StoreClerk entity)
    {
        _context.StoreClerks.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(string id)
    {
        var storeClerk = _context.StoreClerks.Find(id);
        _context.StoreClerks.Remove(storeClerk);
        _context.SaveChanges();
    }
}