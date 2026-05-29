using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Infrastructure;

using ToDoList.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

public class ToDoListContext(DbContextOptions<ToDoListContext> options) : DbContext(options)
{
    public DbSet<TaskItem> TaskItem { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ToDoListContext).Assembly);
    }


    //dotnet ef migrations add InitialCreate --project FinalProject.Infrastructure --startup-project FinalProject.Infrastructure
    //dotnet ef database update InitialCreate --project FinalProject.Infrastructure --startup-project FinalProject.Infrastructure
}
