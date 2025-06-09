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
            //Position position = new Position(3, 4);

            //Console.WriteLine(position);

            Board board = new Board(8, 8);


            board.placePiece(new Rook(board, Colour.White), new Position(0, 0));
            //board.placePiece(new Rook(board, Colour.Black), new Position(1, 3));
            ////tab.placePiece(new King(tab, Colour.Black), new Position(2, 4));
            ////tab.placePiece(new King(tab, Colour.Black), new Position(0, 0));


            Screen.printBoard(board);

            //PositionChess Test
            PositionChess pos = new PositionChess('a', 1);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosition());
            Console.WriteLine("ascii: ");
            Console.WriteLine('d' - 'a');

        }
        catch(BoardException e)
        {
            Console.WriteLine(e.Message);
        }
       
    }
}