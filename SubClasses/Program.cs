
using System;

namespace MasterMind
{
    class MainClass
    {
        static string[] color = new string[2];
        static string[] colorArr = new string[] { "yellow", "blue", "red" };
        static bool gameOver = false;

        public static void Main(string[] args)
        {
            // Generate Code

            Random rnd = new Random();
            int random = rnd.Next(0, 2);
            color[0] = colorArr[random];
            random = rnd.Next(0, 2);
            color[1] = colorArr[random];

            // Ask user input
            while (gameOver == false)
            {
                Console.WriteLine("Pick 2 Colors... Enter your guess [Color1 Color2]: ");
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
                    Console.WriteLine("Your hint is: " + correctColorCount + "-" + correctPositionCount);
                }
            }
        }
    }
}