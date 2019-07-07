using System;
using System.Collections.Generic;

namespace BookInventory
{
    class Program
    {
        static void Main(string[] args)
        {

            BookContext context = new BookContext();
            Console.WriteLine("Would you like to add a book to the list? Type Yes or No");
            while (Console.ReadLine() == "yes")
            {
                context.Database.EnsureCreated();
                Console.WriteLine("Enter Books Title: ");
                string books = Console.ReadLine();

                Console.WriteLine("Enter the Books Author: ");
                string author = Console.ReadLine();

                Book newbook = new Book(books, author);
                context.books.Add(newbook);
                context.SaveChanges();
                Console.WriteLine("Added the Book to List.");
                Console.WriteLine("Would you like to add another book to Inventory list? Type Yes or No");
            }
            Console.WriteLine("The Current List of Books are: ");
            foreach (Book b in context.books)
            {
                Console.WriteLine("{0} - {1} {2}",
                     b.Id, b.Book, b.Author);
            }
        }
    }
}