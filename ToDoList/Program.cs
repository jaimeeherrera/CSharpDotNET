using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoItems
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //ask user for input 
            string Input;
            Console.WriteLine("Would you like to add a new item to the list  YES OR NO?");
            Input = Console.ReadLine();
            //create list 
            List<ToDoItem> myList = new List<ToDoItem>();
            while (Input != "no")
            {
                Console.WriteLine("Please enter a description for new item:");
                string description = Console.ReadLine();
                Console.WriteLine("Please enter a due date for the item:");
                string dueDate = Console.ReadLine();
                Console.WriteLine("Please enter a priority, (High/ Normal/ Low):");
                string priority = Console.ReadLine();
                ToDoItem myItem = new ToDoItem(description, dueDate, priority);
                myList.Add(myItem);
                Console.WriteLine("Would you like to add an item Yes/No ?");
                Input = Console.ReadLine();
            }
            //
            foreach (ToDoItem item in myList)
            {
                Console.WriteLine(item.myToDoList());
            }
        }
        class ToDoItem
        {
            public string Description { get; set; }
            public string DueDate { get; set; }
            public string Priority { get; set; }

            public ToDoItem(string des, string due, string pri)
            {
                Description = des;
                DueDate = due;
                Priority = pri;
            }

            public string myToDoList()
            {
                return (Description + " " + DueDate + " " + Priority);
               

            }
           
        }
    }
}