using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Domain;

public class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public string? ColorHex { get; set; }

    public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();

    public override string ToString()
        => $"Category #{Id}: {Name}";
}
