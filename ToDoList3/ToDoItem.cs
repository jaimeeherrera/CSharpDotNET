using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    public class ToDoItem
    {
        public int Id { get; private set; }
        public string Description { get; set; }
        public string Status { get; set; }
   

        public ToDoItem(string description, string status)
        {
            this.Description = description;
            this.Status = status;
         
        }
    }
}