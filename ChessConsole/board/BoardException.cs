using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole.board
{
    class BoardException : Exception
    {
        public BoardException(string message) : base(message)
        {
        }
    }

}
