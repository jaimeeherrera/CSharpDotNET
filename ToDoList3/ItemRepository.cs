using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ToDoList3
{
    class ItemRepository
    {
        ItemContext context;

        public ItemRepository()
        {
            context = new ItemContext();
            context.Database.EnsureCreated();
        }
        // List all my ToDo Items 

        public List<ToDoItem> GetToDoItems()
        {
            IEnumerable<ToDoItem> list = context.ToDoItems;
            return list.ToList();
        }
        public void AddItem (string description, string status, DateTime dueDate)
        {
            ToDoItem item = new ToDoItem(description, status, dueDate);
            context.ToDoItems.Add(item);
            context.SaveChanges();
        }

        public void UpdateItem(int id, string newDescription, string newStatus, DateTime newDueDate)
        {
            ToDoItem oldItem = context.ToDoItems.Where(Item => Item.Id == id).FirstOrDefault();
            oldItem.Description = newDescription;
            oldItem.Status = newStatus;
            oldItem.DueDate = newDueDate;
            context.Update(oldItem);
            context.SaveChanges();
        }

        public void UpdateItem(ToDoItem item)
        {
            context.Update(item);
            context.SaveChanges();

        }
        public void DeleteItem(int id)
        {
            ToDoItem oldItem = context.ToDoItems.Where(Item => Item.Id == id).FirstOrDefault();
            context.ToDoItems.Remove(oldItem);
            context.SaveChanges();
        }
        public void MarkItem()
        {

        }
        public List<ToDoItem> GetPendingItems()
        {
            IEnumerable<ToDoItem> list = context.ToDoItems.Where(item => item.Status == "Pending");
            return list.ToList();
        }

        public void ListDoneItems()
        {
            IEnumerable<ToDoItem> list = context.ToDoItems.Where(item => item.Status == "Done");
            return list.ToList();
        }
    }
}
