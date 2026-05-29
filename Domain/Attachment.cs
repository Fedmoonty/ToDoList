using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Domain;

public class Attachment
{
    public int Id { get; set; }

    public string FileName { get; set; } = null!;
    public string FilePath { get; set; } = null!;
    public long SizeBytes { get; set; }

    public int TaskItemId { get; set; }
    public TaskItem TaskItem { get; set; } = null!;

    public override string ToString()
        => $"Attachment #{Id}: {FileName} ({SizeBytes} bytes)";
}
