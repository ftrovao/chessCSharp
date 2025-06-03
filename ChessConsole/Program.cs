using board;
using ChessConsole;
using ChessConsole.board;



internal class Program
{
    private static void Main(string[] args)
    {
        Position position = new Position(3, 4);

        Console.WriteLine(position);

        Board tab = new Board(8, 8);

        Screen.printBoard(tab);


    }
}