using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
       
    {
        string[] secert = new string[codeLength];
        string[] colorArray = new string[] { "red", "yellow", "blue" };
        
        static void Main(string[] args)
        {
            string playername;
            Console.WriteLine("Let's Play Mastermind!");
            Console.Write("Please enter your name:");
            playername = Console.ReadLine();
            Console.WriteLine("Let's Play {0}" , playername);
            Console.ReadLine();
            //Generate Random Secret
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                secret[i] = colorArray[rnd.Next(0, 2)];
            }
            //Ask user for input
            Console.WriteLine("Enter your guess:");
            string[] guess = Console.ReadLine().Split('');
            if (guess[0]==secret [0]&& guess[10==secret[1])
                    {
                Console.WriteLine "You won!"
            }
            else
            { 
                int correctColorCount = 0;
                int correctPositionCount = 0;
            if (secret.Contains(guess[0]))
            {
                correctColorCount++;
            }
            if (secret.Contains(guess[1]))
            {
                secretColorCount++;
            }
            if (guess[0]==secret[0])
                {
                    correctPositionCount++;
                }
            if (guess[1])==secret[1]
            //Create a color array to pull from
            ColorArray["Yellow", "Red", "Blue"];


            //get the player to guess the color
            //if the color is correct it will say Congrats
        }

        public void GenerateRandomSecret()
        {
            Random rnd = new Random();
            int randomIndex = rnd.Net(0, 2);
            secret[0] colorrarray[randomIndex];
            randomIndex = rnd.Next(0, 2);
            GenerateRan 1 = colorrArray[randomIndex];
        }
    }
}
