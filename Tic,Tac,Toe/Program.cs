using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tic_Tac_Toe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char player = 'X';
            char[,] board = new char[3, 3];
            //Intializing Board function
            Initialize(board);

            // The Game PLays, until winner/loser/
            while (true)
            {
                Console.Clear();
                Print(board);

                Console.Write("Please enter row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter column: ");
                int col = Convert.ToInt32(Console.ReadLine());

                board[row, col] = player;

                //Check if we won. 
                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                {
                    Console.WriteLine(player + " has won the game");
                    break;
                }
                if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])  // Down Board for X Player
                {
                    Console.WriteLine("Player X has won the game!");
                    Console.ReadKey();

                }

                if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1]) // Middle Down
                {
                    Console.WriteLine("Player X has won the game!");
                    Console.ReadKey();

                }

                if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2]) // Right Down
                {
                    Console.WriteLine("Player X has won the game!");
                    Console.ReadKey();

                }

                if (player == board[0, 2] && player == board[1, 1] && player == board[2, 2])
                {
                    Console.WriteLine("Player X has won the game!");
                    Console.ReadKey();
                }

                if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                {
                    Console.WriteLine("Player X has won the game!");
                    Console.ReadKey();

                }


            }


            if (player == 'O')
            {
                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2]) // Across Board for O player
                {
                    Console.WriteLine("Player O has won the game!");
                    Console.ReadKey();
                    break;
                }

                if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])  // Down Board for O Player
                {
                    Console.WriteLine("Player O has won the game!");
                    Console.ReadKey();

                }

                if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1]) // Middle Down
                {
                    Console.WriteLine("Player O has won the game!");
                    Console.ReadKey();

                }

                if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2]) // Right Down
                {
                    Console.WriteLine("Player O has won the game!");
                    Console.ReadKey();

                }

                if (player == board[0, 2] && player == board[1, 1] && player == board[2, 2])
                {
                    Console.WriteLine("Player O has won the game!");
                    Console.ReadKey();
                }

                if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                {
                    Console.WriteLine("Player O has won the game!");
                    Console.ReadKey();
                }



            }

            ChangeTurn(player);


            //celebrate for winner 
            // clear the screen
            // Print the Board
        }
    }
    static char ChangeTurn(char currentPlayer)
        {
            if (currentPlayer == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }

        }

    static void Initialize(char[,] board)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                board[row, col] = ' ';
            }
        }
    }
        
        static void Print(char[,] board)
        {
        Console.Write("  | 0 | 1 | 2 | ");
        for (int row = 0; row < 3; row++)
            {
            Console.WriteLine(row + " | ");
            for (int col = 0; col < 3; col++)
                {      
                 Console.Write(board[row, col]);
                 Console.Write(" | ");
                }
                Console.WriteLine();
               
            }
            Console.ReadLine();
        }
    }


         
        
      
    
