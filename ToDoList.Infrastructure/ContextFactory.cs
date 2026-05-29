using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ToDoList.Infrastructure;


public class WarehouseItemContextFactory : IDesignTimeDbContextFactory<ToDoListContext>
{
    public ToDoListContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ToDoListContext>();
        optionsBuilder.UseNpgsql("User ID=postgres;password=252525;Host=localhost;Port=5432;Database=ToDoList");
        return new ToDoListContext(optionsBuilder.Options);
    }
}
