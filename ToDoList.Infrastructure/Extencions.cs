using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ToDoList.Infrastructure;

public static class Extencions
{
    public static void AddDatabase(this IServiceCollection services)
    {
        services.AddDbContext<ToDoListContext>(
        o => o.UseNpgsql("User ID=postgres;password=252525;Host=localhost;Port=5432;Database=ToDoList"));
    }
}
