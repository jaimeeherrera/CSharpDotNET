using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tic_Tac_Toe
{
    class Program
    {
        const int BoardSize = 3;
        static string[,] board = new string[BoardSize, BoardSize] { { " ", " " , " " }, { " ", " ", " " }, { " ", " ", " " } };
    
        static void Main(string[] args)
        {
            ResetBoard();
            StartGame();
            Console.Read();
        }

        #region Print the game board
        static void PrintBoard()
        {
            for (int j = 0; j < BoardSize; j++)
            //i is the columns 
            //j is the rows
            {
                Console.WriteLine("-------");
                for (int i = 0; i < BoardSize; i++)
                {
                    Console.Write("|" + board[i, j].ToString());
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("-------");
            Console.Read();
        }
        #endregion

        static void placeMarker (int RowPos, int ColPos)
        {
            int RowIdx = RowPos - 1;
            int ColIdx = ColPos - 1;
            board[RowIdx, ColIdx] = currentPlayer;
            PrintBoard();
        }
        static void ResetBoard()
        {
            PrintBoard();
        }

        static void StartGame()
        {
            PrintBoard();
        }
        
    }
}