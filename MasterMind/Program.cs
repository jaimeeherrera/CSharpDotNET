using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program

    {
        static string[] color = new string[2];
        string[] colorArr = new string[] { "red", "yellow", "blue" };
        static bool gameOver = false;
        static void Main(string[] args)
        {
            //intro to game
            Console.WriteLine("Welcome To MasterMind!");
            Console.WriteLine("I am thining of 2 Colors! I will give you a few hints after each guess!");
            Console.WriteLine("The colors can be either RED, YELLOW, BLUE. You just have to guess the correct order to WIN!");
            Console.ReadLine();
            Console.WriteLine("Lets Play!");
            Console.ReadLine();
            Console.WriteLine("Pick two colors. Example red yellow");
            Console.ReadLine();
            //Generate Code to pull colors
             Random random = new Random();
             int random = rnd.Next(0, 2);
             color[0] = colorsArr[random];
             random = rnd.Next(0, 2);
             color[1] = colorsArr[random];*/
          

            while (gameOver == false)
            {
                Console.WriteLine("Print 2 Colors enter your guess[Color 1 Color2]: ");
                string[] guess = Console.ReadLine().Split(' ');
                if (guess[0] == color[0] && guess[1] == color[1])
                {
                    Console.WriteLine("You have Won!");
                    gameOver = true;
                }
                else
                {
                    int correctColorCount = 0;
                    int correctPositionCount = 0;
                    for (int i = 0; i < 2; i++)
                    {
                        if (guess[0] == color[0] || guess[0] == color[1])
                        {
                            correctColorCount++;
                        }
                        if (guess[1] == color[1] || guess[1] == color[0])
                        {
                            correctColorCount++;
                        }
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        if (guess[0] == color[0])
                        {
                            correctPositionCount++;
                        }
                        if (guess[1] == color[1])
                        {
                            correctPositionCount++;
                        }

                    }
                    Console.WriteLine();
                }
            }
        }

    }
}






