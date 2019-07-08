using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList3
{
    class ConsoleUtilities
    {
        public static string PrintMenu()
        {
            Console.WriteLine(" Please choose your option to conitnue: ");
            Console.WriteLine(" 1 :List ALL TO DO list Items");
            Console.WriteLine(" 2 :Add New Item");
            Console.WriteLine(" 3 :Delete Item");
            Console.WriteLine(" 4 :Mark Item");
            Console.WriteLine(" 5 :List pending Items");
            Console.WriteLine(" 6 :List Done Items ");
            Console.WriteLine(" QUIT : will exit out of the program ");
            //need to print menu with options example A: List All Items 
            string action = Console.ReadLine();
            return action;

        }
        public static void PrintToDoItems(List<ToDoItem> list)
            {
            foreach (ToDoItem item in list) 
            {
                Console.WriteLine($"{item.Id} - {item.Description } - {item.Status}");
            }
                
            //need to creat a loop to go through to list the info for every item
            }

    public static string AskForItemInfo()  //all are defined as static because they do not have properties to set they are tools that are called directly

        {
            Console.WriteLine("Enter the TO DO LIST ITEM with a | to seperate EX. 'Desciription | Status | Date': ");
            string userInput = Console.ReadLine();
            string itemInfo = (userInput);
            return itemInfo;

        }
    public static int GetItemId()
        {
            Console.WriteLine("Enter the Id of the item: ");
            string userInput = Console.ReadLine();
            int itemId = int.Parse(userInput);
            return itemId; 
            //called the function and grab the id back

        }
    }
}
