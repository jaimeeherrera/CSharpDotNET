using System;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ItemRepository repo = new ItemRepository();
            repo.GetToDoItems();
        }

        public ToDoList3<ToDoItem> Get

            ItemContext context = new ItemContext();
            context.Database.EnsureCreated();

            IEnumberable<ToDoItem> list = context.ToDoItems;
            return list.toList();

        }
    }
}
