﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board
{
    internal class Position
    {
        public int row { get; set; }
        public int column { get; set; }

        public Position(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public void setValues(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public override string ToString()
        {
            return row + ", " + column;
        }



    }
}
