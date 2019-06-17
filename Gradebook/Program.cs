
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Program
    {
        static string name;

        static void Main(string[] args)
        {

            //Dictionary 
            Dictionary<string, string> Gradebook = new Dictionary<string, string>();

            while (name != "quit")
            {

                string quit = "quit";

                Console.WriteLine("Welcome to your Grade Book! Enter student's name or 'quit' to finish");
                string grades = " ";
                name = Console.ReadLine();

                if (name.ToLower() == quit)

                {
                    break; 
                }

                //ask for grades
                Console.WriteLine("Enter {0}'s grades,  or type 'quit' for gradebook results.", name);
                grades = Console.ReadLine();
                // add to dictionary
                Gradebook.Add(name, grades);
                Console.Clear();



            }

            Console.Clear();

            foreach (var name in Gradebook.Keys) 
            {
                // Split Strings
                string[] gradesSplit = Gradebook[name].Split(' ');
                int[] grades2nums = Array.ConvertAll(gradesSplit, int.Parse);
                //find highest grade
                int highestGrade = grades2nums.Max();
                //lowest grade
                int lowestGrade = grades2nums.Min();
                //average grade
                double avgGrade = grades2nums.Average();
                // all of calculations for student
                Console.WriteLine("Student: " + name);
                Console.WriteLine("Highest Grade: " + highestGrade);
                Console.WriteLine("Lowest Grade: " + lowestGrade);
                Console.WriteLine("Avg Grade: " + avgGrade);
                Console.WriteLine("________");



            }

            Console.Read();

        }


    }
}



