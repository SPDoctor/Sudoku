using Sudoku;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    public class SudokuGrid : Grid
    {

        public SudokuGrid() : base(9, 9)
        {

        }

        public bool Solve()
        {
            // TODO: for each row and column and square, call SolveCells
            Cell[] cells = new Cell[9];
            for (int i = 0; i < 9; i++)
            {
                cells[i] = GetCell(i, 0);
            }
            SolveCells(cells);

            // TODO: return true if all cells solved
            return true;
        }

        public void SolveCells(Cell[] cells)
        {
            // TODO: add a test project to verify
            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i].value > 0)
                    for (int j = 0; j < cells.Length; j++)
                        if(j != i)
                            cells[j].Eliminate(cells[i].value);
            }
        }
    }
}
