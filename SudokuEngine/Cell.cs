using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    public class Cell
    {
        public int value;
        bool[] possible = new bool[9];

        public Cell(int value)
        {
            this.value = value;
            for (int i = 0; i < 9; i++) possible[i] = (value != 0);
            if (value != 0) possible[value - 1] = true;
        }

        public void Eliminate(int i)
        {
            possible[i] = false;
        }
    }
}
