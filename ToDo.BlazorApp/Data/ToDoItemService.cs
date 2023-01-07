using System.Text.Json;

namespace ToDo.BlazorApp.Data;

public class ToDoItemService
{
    private static List<ToDoItem> _data = new List<ToDoItem>()
    {
        new ToDoItem { Title = "Meet Donald Trump" },
        new ToDoItem { Title = "Lunch with Barrack Obama" },
        new ToDoItem { Title = "Go fishing with Bill Gate" },
        new ToDoItem { Title = "Walking with Putin" }
    };

    private readonly string _file = "Data\\todo.json";

    public List<ToDoItem> GetData()
    {
        if (File.Exists(_file))
        {
            string json = File.ReadAllText(_file);
            _data = JsonSerializer.Deserialize<List<ToDoItem>>(json)!;
        }
        return _data;
    }

    public void SaveChange()
    {
        string serialize = JsonSerializer.Serialize<List<ToDoItem>>(_data);
        File.WriteAllText(_file,serialize);
    }
}