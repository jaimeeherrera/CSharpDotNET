
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerHanoi
{
    //Creating 3 Towers
    //Creating Dictionay 
    //Creating Stack
    class MainClass
    {
        static Dictionary<String, Stack<int>> towers = new Dictionary<string, Stack<int>>();

        public static int stackCount = 0;
   
    //*********Main Program*************
        public static void Main(string[] args)
        {
            towers.Add("A", new Stack<int>());
            towers.Add("B", new Stack<int>());
            towers.Add("C", new Stack<int>());
            for (int i = 4; i > 0; i--)
            {
                towers["A"].Push(i);
            }
            while (towers["B"].Count != 4 || towers["C"].Count != 4)
            {
                playingBoard();
                GamesMove();
                if (Win())
                {
                    Console.WriteLine("You did it! You won!!");
                }
                else
                {
                    continue;
                }
            }
            Console.ReadLine();
        }
    
    //<<<<<Game Funcitons>>>>>



        //print playing board
        public static void playingBoard()
        {
            foreach (var key in towers.Keys)
            {
                Console.Write(key + " : ");
                Stacks(towers[key]);
                Console.WriteLine();
            }
        }
        //LOOP TO CHECK FOR WINNER
        public static int WinCount = 4;
        public static bool Win()
        {
            if (towers["C"].Count == WinCount)
            {
                return true;
            }
            else if (towers["B"].Count == WinCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Games Moves
        public static void GamesMove()
        {
            Console.WriteLine("Which tower would you like to move from?'Tower A, Tower B, Tower C?'");
            string fStack = Console.ReadLine();
            Console.WriteLine("Which tower would you like to move to?'Tower A, Tower B, Tower C?'");
            string tStack = Console.ReadLine();
            if (LegalMove(fStack, tStack))
            {
                towers[tStack].Push(towers[fStack].Peek());
                towers[fStack].Pop();

            }
        }
        //Check for legal Move
        public static bool LegalMove(string f, string t)
        {
            if (towers[f].Count != 0 && (towers[t].Count == 0 || towers[f].Peek() < towers[t].Peek()))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Sorry! You Can't move  this Disc! You can not move a bigger disc onto a smaller disc");
                return false;
            }
        }

        //STACKS
        public static void Stacks(Stack<int> stack)
        {
            int[] arrTower = stack.ToArray();
            for (int i = arrTower.Length - 1; i >= 0; i--)
            {
                Console.Write(arrTower[i] + " ");
            }

        }
      
       
       

    }
}