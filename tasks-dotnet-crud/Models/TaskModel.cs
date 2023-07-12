namespace tasks_dotnet_crud.Models;

public class TaskModel
{
    public int     Id           { get; set; }
    public string? Name         { get; set; }
    public string? Description  { get; set; }
    public int     status       { get; set; }
}