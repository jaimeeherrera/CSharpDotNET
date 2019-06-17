using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerHanoi
{
    //Create the 3 towers using Dictionary and stacks
    class MainClass
    {
        static Dictionary<String, Stack<int>> towers = new Dictionary<string, Stack<int>>();

        public static int stackCount = 0;
        public static void Main(string[] args)
        {
            towers.Add("Tower A", new Stack<int>());
            towers.Add("Tower B", new Stack<int>());
            towers.Add("Tower C", new Stack<int>());
            for (int i = 4; i > 0; i--)
            {
                towers["Tower A"].Push(i);
            }
            while (towers["Tower B"].Count != 4 || towers["Tower C"].Count != 4)
            {
                Board();
                GamesMove();
                if (Winner())
                {
                    Console.WriteLine("You have Won!");
                }
                else
                {
                    continue;
                }
            }
            Console.ReadLine();
        }
        //moves the discs from tower to tower
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
        public static void Stacks(Stack<int> stack)
        {
            int[] arrTower = stack.ToArray();
            for (int i = arrTower.Length - 1; i >= 0; i--)
            {
                Console.Write(arrTower[i] + " ");
            }

        }
        //print board
        public static void Board()
        {
            foreach (var key in towers.Keys)
            {
                Console.Write(key + " : ");
                Stacks(towers[key]);
                Console.WriteLine();
            }
        }
        //check legal move
        public static bool LegalMove(string f, string t)
        {
            if (towers[f].Count != 0 && (towers[t].Count == 0 || towers[f].Peek() < towers[t].Peek()))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Can't move Disc! You can not move a bigger disc onto a smaller disc");
                return false;
            }
        }
        //Check for winner
        public static int WinCount = 4;
        public static bool Winner()
        {
            if (towers["Tower C"].Count == WinCount)
            {
                return true;
            }
            else if (towers["Tower B"].Count == WinCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}