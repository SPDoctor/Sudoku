using Sudoku;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    public class SudokuGrid : Grid
    {
        SudokuGrid(int rows, int cols) : base(rows, cols)
        {

        }

        public SudokuGrid() : base(9,9)
        {

        }

    }
}
