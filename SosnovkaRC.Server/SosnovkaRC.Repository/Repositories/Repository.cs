using Microsoft.EntityFrameworkCore;
using SosnovkaRC.Domain.Models;

namespace SosnovkaRC.Repository.Repositories;

public interface IRepository<T> where T : Entity
{
    Task<T?> GetByIdAsync(int id);
    Task<T[]> GetAsync(int skip = 0, int? take = null);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
    Task DeleteAsync(T entity);
    Task SaveAsync();
}

public class Repository<T> : IRepository<T> where T : Entity
{
    protected readonly SosnovkaContext Context;

    public Repository(SosnovkaContext context)
    {
        Context = context;
    }

    public async Task<T?> GetByIdAsync(int id) => await Context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);

    public async Task<T[]> GetAsync(int skip = 0, int? take = null)
    {
        IQueryable<T> query = Context.Set<T>();
        if (skip > 0)
            query = query.Skip(skip);

        if (take > 0)
            query = query.Take(take.Value);
        return await query.ToArrayAsync();
    }

    public async Task AddAsync(T entity)
    {
        await Context.Set<T>().AddAsync(entity);
        await SaveAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        Context.Set<T>().Update(entity);
        await SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
            await DeleteAsync(entity);
    }

    public async Task DeleteAsync(T entity)
    {
        Context.Set<T>().Remove(entity);
        await SaveAsync();
    }

    public async Task SaveAsync() => await Context.SaveChangesAsync();
}