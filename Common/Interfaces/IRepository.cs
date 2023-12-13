namespace Common.Interfaces;

public interface IRepository<TEntity, in TId>
    where TEntity : IEntity<TId>
{
    TEntity GetById(TId id);
    IEnumerable<TEntity> GetAll();
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TId id);
}