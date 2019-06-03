using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello method 
            //Hello();
            //Addition method
            //Addition();
            //CatDog Method
            //CatDog();
            //oddEvent
            //OddEvent();
            //inches;
            //inches();
            //Echo
            Echo();


        }

        public static void Hello()
        {
            Console.WriteLine("Hello! What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Bye " + name + "!");
            Console.Read();
        }

        public static void Addition()
        {
            Console.WriteLine("Please enter your first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the two numbers you entered is " + (num1 + num2));
            Console.Read();

        }

        public static void CatDog()
        {
            Console.WriteLine("Please enter what you love more: Cats or Dogs");
            String choice = Console.ReadLine();
            if (choice == "cats")
            {
                Console.WriteLine(" I love cats too, MEOW MEOW! ");
                Console.ReadLine();
            }
            if (choice == "dogs")
            {
                Console.WriteLine(" WOOF WOOF ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have to pick one, don't try and cheat!!");
                Console.ReadLine();
            }
        }
        public static void OddEvent()
        {
            int num;
            Console.WriteLine("Please enter a number: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The number you entered is even.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The number you entered is odd.");
                Console.ReadLine();
            }
            Console.Read();
        }

        public static void inches()
        {
            Console.WriteLine("Enter Your Height in feet: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Your correct height is " + (num1 * 12)+ " inches!");
            Console.Read();
        }

        public static void Echo()
        {
            Console.WriteLine("Enter your favorite kinds of candy?");
            Console.Read();
            string Candy1 = Console.ReadLine();
            Console.WriteLine("These are your favorite: " + Candy1);
            Console.ReadLine(); 
            

        }




    }
    }

