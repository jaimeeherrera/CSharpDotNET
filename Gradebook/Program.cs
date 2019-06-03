using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking user if they want to quit
            Console.WriteLine("Welcome to your amazing Grade Book!If you would like to exit at anytime type quit!");

            Dictionary<string, string> studentGrades = new Dictionary<string, string>();
            while (name.ToLower() != "quit")
            {
                Console.WriteLine("Please enter grade, seperated by a blank spafce: ");
                string strGrades = Console.ReadLine();
                studentGrades.Add(name, strGrades);
                Console.WriteLine("Enter student's name, or 'quit' to finsih;");
                name = Console.ReadLine();

            }

            string sName;
            string sGrades;
            string[] arrayGrades;
            int[] iGrades;
            foreach (var i in studentGrades.Keys)
            {
                sName = i;
                sGrades = studentGrades[i];
                ArrayGrades = sGrades.Split('');

            }
            iGrades = Array.ConvertAll(arrayGrades, int.Parse);
            Console.Read()l
            // now the user entered 'quit', we need to calculate the grades 
            // we need to loop through the studentGrades dictionary
            foreach ( var i in studentGrades.Keys)
            {
                string g = studentGrades[i];
                Console.WriteLine($"Name; {i}");
                Console.WriteLine($"Grades; {studentGrades[i]}");
            }
            //have user enter the name 
            //have user enter grade 
            //create this as a loop 
            //when quit display the name and grade 
        }
    }
}
