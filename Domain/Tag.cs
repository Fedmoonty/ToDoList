using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Domain;

public class Tag
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();

    public override string ToString()
        => $"Tag #{Id}: {Name}";
}
