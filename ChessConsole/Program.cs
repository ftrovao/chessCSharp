using board;
using ChessConsole;
using ChessConsole.board;
using ChessConsole.chess;



internal class Program
{
    private static void Main(string[] args)
    {

        try
        {
            Position position = new Position(3, 4);

            Console.WriteLine(position);

            Board tab = new Board(8, 8);



            tab.placePiece(new Rook(tab, Colour.Black), new Position(0, 0));
            tab.placePiece(new Rook(tab, Colour.Black), new Position(1, 3));
            //tab.placePiece(new King(tab, Colour.Black), new Position(2, 4));
            tab.placePiece(new King(tab, Colour.Black), new Position(0, 9));


            Screen.printBoard(tab);
        }
        catch(BoardException e)
        {
            Console.WriteLine(e.Message);
        }
       
    }
}