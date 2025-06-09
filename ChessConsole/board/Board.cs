using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board;

namespace ChessConsole.board
{
    internal class Board
    {
        public int rows { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            pieces = new Piece[rows, columns];
        }

        //
        public Piece piece(int row, int column)
        {
            return pieces[row, column];
        }
        //improvement
        public Piece piece(Position pos)
        {
            return pieces[pos.row, pos.column];
        }

        public bool existsPiece(Position pos)
        {
            validatePosition(pos);
            return piece(pos) != null;
        }

        public void placePiece(Piece p, Position pos)
        {


            if (existsPiece(pos))
            {
                throw new BoardException("There is already a piece at this position!");
            }
            p.Position = pos;
            pieces[pos.row, pos.column] = p;
          
            //p.Position = pos;* check why this is put after Piece was added to matrix
            Console.WriteLine("p.position" + p.Position.row);
        }

        //public Piece removePiece(Position pos)
        //{
        //    if (piece(pos) == null)
        //    {
        //        return null;
        //    }
        //    Piece aux = piece(pos);
        //    aux.position = null;
        //    pieces[pos.row, pos.column] = null;
        //    return aux;
        //}

        public bool isValidPosition(Position pos)
        {
            if (pos.row < 0 || pos.row >= rows || pos.column < 0 || pos.column >= columns)
            {
                return false;
            }
            return true;
        }

        public void validatePosition(Position pos)
        {
            if (!isValidPosition(pos))
            {
                throw new BoardException("Invalid position!");
            }
        }
    }
}
