using System;
using System.Collections.Generic;

public struct Position
{
    public int row { get; private set; }
    public int col { get; private set; }
    public Position(int row, int col)
    {
        this.row = row;
        this.col = col;
    }
}

public enum Color { White, Black }

#region Checker
public class Checker
{
    public String Symbol { get; private set; }
    public Color Team { get; private set; }
    public Position Position { get; set; }

    public Checker(Color team, int row, int col)
    {
        if( player == Color.White)
        {
            Symbol = "25CF";
            Team = Color.White;
        }
        else
        {
            Symbol = " 25CB";
            Team = Color.Black;             
        }
    }

}
#endregion Checker

#region Board
public class Board
{
    public List<Checker> checkers; //this is the list 
    public Board()
    {
        checkers = new List<Checker>();            
        for (int r = 0; r < 3; r++)
        {
            for (int i = 0; i < 8; i += 2)
            {
                Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);   //add each checker into the list.... starts with the white pieces 
                checkers.Add(c);                                            
            }
            for (int i = 0; i < 8; i += 2)
            {
                Checker c = new Checker(Color.Black, 5 + r, (r) % 2 + i);
                checkers.Add(c);
            }
        }
    }

    public Checker GetChecker(Position pos) 
    {
      foreach (Checker c in checker)
        {
            if (c.Position.row == source.Row && c.Position.Column == source.Column)
            {
                return c;
            }
        }
        return null;
    }

    public void RemoveChecker(Checker checker)
    {
        Checker c = new Checker(checker.Team, destination.Row, destination.Column);
        checker.Remove(checker);
        checker.Add(c)
    }

    public void MoveChecker(Checker checker, Position destination)
    {
        Checker c = new Checker(checker.Team, destination.Row, destination.Column);
        checkers.Remove(checker);
        checkers.Add(c);
        checker.position;
     

    }

}

#endregion Board

public class Game
{
    private Board board;
    public Game()
    {
        this.board = new Board();
    }

    private bool CheckForWin()
    {
        
    }

    public void Start()
    {
        // ...
    }

    public bool IsLegalMove(Color player, Position src, Position dest)
    {
        if (source.Row < 0) || sourse.Row >7 || source.Column < 0 || source.Column >7
                || destination.Row < 0 || destination. Row >  Row. > 7 || destination.Column < 0
                || destination.Column > 7) return false; 

        int rowDistance == Math.Abs(destination.Row - source.Row);
        int colDistance == Math.Abs(destination.Column - source.Column);

        if (colDistance == 0 || rowDistance == 0) return false;
        if (rowDistance / colDistance! = 1) return false;

        int row_mid = (destination.Row + source.Row) / 2;
        int col_mid = (destination.Column + source.Column / 2);
        Position p = new Position(row_mid, col_mid);
        c = Board.GetChecker(p);
        if (c == null)
        {
            return false;
        }
        else
        {
            if (c.Team == player)
            {
                return false;
            }
        }
    }
    else { 
    return true;
    }


    

public bool IsCapture(Color player, Position source, Position destination)
    {
        int rowDistance = Math.Abs(destination.Row - source.Row);
        int colDistance = Math.Abs(destination.Column - source.Column);
        if (rowDistance == 2 && colDistance == 2) return true;
        {
            int row_mid = (destination.Row + source.Row) / 2;
            int col_mid = (destination.Column + source.Column) / 2;
            Position p = new Position(row_mid, col_mid);
            Checker c = board.GetChecker(p);
            if (c==null)
            {
                return false;
            }
        }
    }

    public Checker GetCaptureChecker(Color player, Position source, Position destination)
    {
        if(IsCapture(player, source, destination))
        {
            int row_mid = (destination.row + source.row) / 2;
            int col_mid = (destination.Column + source.Column) / 2;
            Position p = new Postion(row_mid, col_mid);
            Checker c = board.GetChecker(p);
            return c; 

        }
        return null;

    }

    public Position ProcessInput()
    {
       if (colDistance --
            // ...
    }

    public void DrawBoard()
    {
        String[][] grid = new String[8][];
        for (int r = 0; r < 8; r++)
        {
            grid[r] = new String[8];
            for (int c = 0; c < 8; c++)
            {
                grid[r][c] = " ";
            }
        }
        foreach (Checker c in board.checkers)
        {
            grid[c.position.row][c.position.col] = c.symbol;
        }

        Console.WriteLine("  0 1 2 3 4 5 6 7");
        for (int r = 0; r < 8; r++)
        {
            Console.Write(r);
            for (int c = 0; c < 8; c++)
            {
                Console.Write(" {0}", grid[r][c]);
            }
            Console.WriteLine();
        }
    }

   
}

class Program
{
    public static void Main(String[] args)
    {
        Game game = new Game();
        game.Start();
    }
}

