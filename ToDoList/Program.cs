using System;

class Program
{
    static void Main(string[] args)
    {
        var todoList = new TodoList();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("To-Do List:");
            foreach (var item in todoList.GetItems())
            {
                Console.WriteLine($"{item.Id}. {item.Description} - {(item.IsCompleted ? "Completed" : "Pending")}");
            }

            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Add a new item");
            Console.WriteLine("2. Complete an item");
            Console.WriteLine("3. Remove an item");
            Console.WriteLine("4. Exit");

            var input = Console.ReadLine();
            if (input == "4") break;

            switch (input)
            {
                case "1":
                    Console.Write("Enter the description of the new item: ");
                    var description = Console.ReadLine();
                    todoList.AddItem(description);
                    break;
                case "2":
                    Console.Write("Enter the ID of the item to complete: ");
                    if (int.TryParse(Console.ReadLine(), out int completeId))
                    {
                        todoList.CompleteItem(completeId);
                    }
                    break;
                case "3":
                    Console.Write("Enter the ID of the item to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int removeId))
                    {
                        todoList.RemoveItem(removeId);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
