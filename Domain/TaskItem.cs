using System;
using System.Net.Mail;

namespace ToDoList.Domain;

public class TaskItem
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;
    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime? CompletedAt { get; set; }

    public TaskStatus Status { get; set; }
    public TaskPriority Priority { get; set; }

    public int? CategoryId { get; set; }
    public Category Category { get; set; } 


    public ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public ICollection<SubTask> SubTasks { get; set; }

    public int UserId { get; set; }

    public override string ToString()
        => $"Task #{Id}: '{Title}', Status={Status}, Priority={Priority}, Due={DueDate?.ToShortDateString() ?? "—"}";
}

public enum TaskStatus
{
    New,
    InProgress,
    Completed,
    Archived
}

public enum TaskPriority
{
    Low,
    Medium,
    High,
    Critical
}
