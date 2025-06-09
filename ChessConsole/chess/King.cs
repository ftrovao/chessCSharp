using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board;
using ChessConsole.board;

namespace ChessConsole.chess
{
    internal class King : Piece
    {
        //public King(Board board, Colour color, ChessMatch match) : base(board, color)
        //{
        //    this.match = match;
        //}

        //test
        public King(Board board, Colour color ) : base(board, color)
        {
           
        }
        
        public override string ToString()
        {
            return "K";
        }

    }
}
