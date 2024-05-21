using System;
using System.Collections.Generic;
using ToDoList;

public class TodoList
{
    private List<TodoItems> items = new List<TodoItems>();
    private int nextId = 1;

    public void AddItem(string description)
    {
        var item = new TodoItems { Id = nextId++, Description = description, IsCompleted = false };
        items.Add(item);
    }

    public void CompleteItem(int id)
    {
        var item = items.Find(i => i.Id == id);
        if (item != null)
        {
            item.IsCompleted = true;
        }
    }

    public void RemoveItem(int id)
    {
        var item = items.Find(i => i.Id == id);
        if (item != null)
        {
            items.Remove(item);
        }
    }

    public List<TodoItems> GetItems()
    {
        return items;
    }
}
