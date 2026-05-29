using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList.Domain;

namespace ToDoList.Infrastructure;

public class TaskItemConfiguration : IEntityTypeConfiguration<TaskItem>
{
    //Migration config
    public void Configure(EntityTypeBuilder<TaskItem> builder)
    {
        builder.ToTable("TaskItems");

        builder.HasKey(t => t.Id);

        builder.Property(t => t.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(t => t.Description)
            .HasMaxLength(2000);

        builder.Property(t => t.CreatedAt)
            .IsRequired();

        builder.Property(t => t.Status)
            .IsRequired();

        builder.Property(t => t.Priority)
            .IsRequired();

        builder.HasOne(t => t.Category)
            .WithMany(c => c.Tasks)
            .HasForeignKey(t => t.CategoryId)
            .OnDelete(DeleteBehavior.SetNull);

        //Seeding data
        builder.HasData(
        new TaskItem
        {
            Id = 1,
            Title = "Купить продукты",
            Description = "Молоко, хлеб, яйца",
            CreatedAt = new DateTime(2024, 01, 01, 12, 0, 0, DateTimeKind.Utc),
            Status = ToDoList.Domain.TaskStatus.New,
            Priority = TaskPriority.Medium,
            CategoryId = null
        },
        new TaskItem
        {
            Id = 2,
            Title = "Сделать уборку",
            Description = "Пропылесосить и вымыть полы",
            CreatedAt = new DateTime(2024, 01, 01, 12, 0, 0, DateTimeKind.Utc),
            Status = ToDoList.Domain.TaskStatus.New,
            Priority = TaskPriority.Low,
            CategoryId = null
        },
        new TaskItem
        {
            Id = 3,
            Title = "Подготовиться к экзамену",
            Description = "Повторить главы 3–5",
            CreatedAt = new DateTime(2024, 01, 01, 12, 0, 0, DateTimeKind.Utc),
            Status = ToDoList.Domain.TaskStatus.InProgress,
            Priority = TaskPriority.High,
            CategoryId = null
        }
        );

    }
}
