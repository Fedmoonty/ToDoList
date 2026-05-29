namespace ToDoList.Domain;

public class SubTask
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;
    public bool IsDone { get; set; }

    public int TaskItemId { get; set; }
    public TaskItem TaskItem { get; set; } = null!;

    public override string ToString()
        => $"SubTask #{Id}: '{Title}', Done={IsDone}";
}