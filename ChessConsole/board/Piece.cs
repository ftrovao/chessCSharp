using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board;

namespace ChessConsole.board
{
    internal class Piece
    {

        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MoveCount { get; protected set; }
        //============================
        //The board "has" the pieces(it stores and manages them).

        //The piece "knows" the board in order to act based on the game context.
        //============================
        public Board GameBoard { get; protected set; }


        public Piece(Board board, Color color)
        {
            this.Position = null;
            this.GameBoard = board;
            this.Color = color;
            this.MoveCount = 0;
        }

        public void IncrementMoveCount()
        {
            MoveCount++;
        }

        //public void DecrementMoveCount()
        //{
        //    MoveCount--;
        //}

        //public bool HasPossibleMoves()
        //{
        //    bool[,] mat = PossibleMoves();
        //    for (int i = 0; i < Board.Rows; i++)
        //    {
        //        for (int j = 0; j < Board.Columns; j++)
        //        {
        //            if (mat[i, j])
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        //public bool IsMovePossible(Position pos)
        //{
        //    return PossibleMoves()[pos.Row, pos.Column];
        //}

        //public abstract bool[,] PossibleMoves();

    }
}
