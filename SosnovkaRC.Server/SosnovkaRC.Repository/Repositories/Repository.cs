using SosnovkaRC.Domain.Models;

namespace SosnovkaRC.Repository.Repositories;

public interface IRepository<T> where T : Entity
{
    T? GetById(int id);
    T[] Get(int skip = 0, int? take = null);
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
    void Delete(T entity);
    void Save();
}

public class Repository<T> : IRepository<T> where T : Entity
{
    protected readonly SosnovkaContext Context;

    public Repository(SosnovkaContext context)
    {
        Context = context;
    }

    public T? GetById(int id) => Context.Set<T>().FirstOrDefault(e => e.Id == id);

    public T[] Get(int skip = 0, int? take = null)
    {
        IQueryable<T> query = Context.Set<T>();
        if (skip > 0)
            query = query.Skip(skip);

        if (take > 0)
            query = query.Take(take.Value);
        return query.ToArray();
    }

    public void Add(T entity)
    {
        Context.Set<T>().Add(entity);
        Save();
    }

    public void Update(T entity)
    {
        Context.Set<T>().Update(entity);
        Save();
    }

    public void Delete(int id)
    {
        var entity = GetById(id);
        if (entity != null)
            Delete(entity);
    }

    public void Delete(T entity)
    {
        Context.Set<T>().Remove(entity);
        Save();
    }

    public void Save() => Context.SaveChanges();
}