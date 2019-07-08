using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList3
{
    public class App
    {

        ItemRepository repo; 
        public App()
        {
            repo = new ItemRepository();
        }
        private void DisplayALL()
        {
            List<ToDoItem> list = repo.GetToDoItems();
            ConsoleUtilities.(list);
        }
        public void Start()
        {
            //1. Display Menu 
            string action = ConsoleUtilities.PrintMenu();
            //2. Process user actions 
            while (action! = "Quit")
            {
                if (action == "1") {
                    List<ToDoItem> list = repo.GetToDoItems();
                    ConsoleUtilities.PrintToDoItems(list);
                }
                // use else if  or if
                // ask itemRepositoy to return list of ToDoitem
                // ask Console Utilites to display list 
                //break 
                else if (action == "2")
                {
                    string Userinput = ConsoleUtilities.AskForItemInfo(); //creates a variable 
                    string[] iteminfo = Userinput.Split('|'); 
                    repo.AddItem(iteminfo[0], iteminfo[1], DateTime.Parse(iteminfo[2]));
                    List<ToDoItem> list = repo.GetToDoItems();
                    ConsoleUtilities.PrintToDoItems(list);
                }
                //CREATE NEW ITEM
                //if action is to create a new item 
                // ask consoleutilies to get the item info from user 
                //ask item repository to create a todo item 
                // ask consoleutilites to display the current list
                // break
                else if (action == "3")
                {
                    ConsoleUtilities.GetItemId();
                    repo.DeleteItem();
                    ConsoleUtilities.PrintToDoItems();

                }
                // DELETE ITEM
                // if action is to delete 
                //ask console utitlies to get the itme from the user 
                //ask item repsotiory to delete 
                // break 
                else if (action == "4")
                {


                }
                //MARK ITEM
                //if action is to mark item 
                //ask console


                else if (action =="5")
                {
                    repo.GetPendingItems();
                    Console.WriteLine();
                    DisplayALL();

                }
                // LIST PENDING ITEMS
    
                else if (action =="6")
                {
                    repo.ListDoneItems();
                    Console.WriteLine();
                    DisplayALL();
                }
                //LIST DONE ITEMS
            }
            //3. 
        }
        //ConsoleUtils utility;
    }
}
