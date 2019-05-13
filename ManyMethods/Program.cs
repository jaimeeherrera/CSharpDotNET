﻿using System;
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
            //Echo();
            //Kilograms Method
            //Kilograms();
            //Date
            //Date();
            //Age
            //Age();
            //Guess
            Guess();


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
            //writes the line that asks the user the a question
            Console.WriteLine("Lets say you are on top of the world what word would you shout?: ");
            //creates the input in to a string so it can be printed with upper and lower
            string echo1 = Console.ReadLine().ToUpper();
            string echo2 = echo1.ToLower();
            //prints the code 
            Console.WriteLine(echo1);
            Console.WriteLine(echo2);
            Console.WriteLine(echo2);
            Console.Read();
        
        }

        public static void Kilograms()
        {
            Console.WriteLine("Please state what your weight is in pounds?: ");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Your correct weight is " + (weight * 0.454) + " in Kilograms!");
            Console.Read();
        }

        public static void Date()
        {
            Console.WriteLine("The current Date and Time:");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.Read();
        }

        public static void Age()
        {
            Console.WriteLine("What year were you born?:");
            int borndate = int.Parse(Console.ReadLine());
            Console.WriteLine("You are" + (borndate - 2019) + "years old!");
            Console.Read();
        }

        public static void Guess()
        {
            Console.WriteLine("I'm thinking of a word, try and guess it!? ");
            string guess1 = Console.ReadLine();
            if (guess1 == "Csharp")
            {
                Console.WriteLine("Great job! You guessed corret!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry that wasn't right, maybe next time!");
                Console.ReadLine();
            }
        }
    }
    }

