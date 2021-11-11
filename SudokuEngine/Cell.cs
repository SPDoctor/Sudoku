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

        void checkSolved()
        {
            if (value > 0) return; //already solved
            var count = 0;
            var v = 0;
            for (int i = 0; i < 9; i++) if (possible[i])
                {
                    count++;
                    v = i+1;
                }
            if (count == 1) value = v;
        }

        public void Eliminate(int i)
        {
            if (value > 0) return;
            possible[i-1] = false;
            checkSolved();
        }
    }
}
