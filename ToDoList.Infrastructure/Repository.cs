using Microsoft.EntityFrameworkCore;
using ToDoList.Domain;

namespace ToDoList.Infrastructure;

public class Repository<T> : IRepository<T> where T : TaskItem
{
    private readonly ToDoListContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(ToDoListContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _dbSet
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task AddAsync(T item)
    {
        await _dbSet.AddAsync(item);
    }

    public void Update(T item)
    {
        _dbSet.Update(item);
    }

    public void Delete(T item)
    {
        _dbSet.Remove(item);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAllItemsAsynk()
    {
        var items = await _dbSet.ToListAsync();
        _dbSet.RemoveRange(items);
    }
}
