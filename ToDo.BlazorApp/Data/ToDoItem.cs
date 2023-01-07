using System.Data.SqlTypes;

namespace ToDo.BlazorApp.Data;

public class ToDoItem
{
    public string Title { get; set; }
    public bool Done { get; set; }
    public string Note { get; set; }
}
