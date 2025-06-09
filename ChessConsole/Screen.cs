using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessConsole.board;

namespace ChessConsole
{
    internal class Screen
    {
        //public static void printMatch(ChessMatch match)
        //{
        //    printBoard(match.board);
        //    Console.WriteLine();
        //    printCapturedPieces(match);
        //    Console.WriteLine();
        //    Console.WriteLine("Turn: " + match.turn);
        //    if (!match.finished)
        //    {
        //        Console.WriteLine("Waiting for move: " + match.currentPlayer);
        //        if (match.inCheck)
        //        {
        //            Console.WriteLine("CHECK!");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("CHECKMATE!");
        //        Console.WriteLine("Winner: " + match.currentPlayer);
        //    }
        //}


        //methode pour tester et afficher le board
        public static void printBoard(Board board)
        {
            for (int i = 0; i < board.rows; i++)
            {
                //Console.Write(8 - i + " ");
                for (int j = 0; j < board.columns; j++)
                {
                    if(board.piece(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.piece(i,j)+ " ");
                    }
                    
                    //printPiece(board.piece(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        //=================================================




    }
}

