using Sudoku;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    public class SudokuGrid : Grid
    {
        ILogger logger;

        public SudokuGrid() : base(9, 9)
        {
            this.logger = new ConsoleLogger();
        }

        public SudokuGrid(ILogger logger) : base(9, 9)
        {
            this.logger = logger;
        }

        public bool Solve()
        {
            // check each row and call SolveCells
            for (int j = 0; j < 9; j++)
            {
                logger.Log("Checking row " + j);
                Cell[] cells = new Cell[9];
                for (int i = 0; i < 9; i++)
                {
                    cells[i] = GetCell(i, j);
                }
                SolveCells(cells);
            }

            // check each column and call SolveCells
            for (int i = 0; i < 9; i++)
            {
                logger.Log("Checking column " + i);
                Cell[] cells = new Cell[9];
                for (int j = 0; j < 9; j++)
                {
                    cells[j] = GetCell(i, j);
                }
                SolveCells(cells);
            }

            // check each square and call SolveCells
            for (int iSquare = 0; iSquare < 3; iSquare++)
            {
                for (int jSquare = 0; jSquare < 3; jSquare++)
                {
                    //logger.Log("Checking square " + iSquare + "/" + jSquare);
                    Cell[] cells = new Cell[9];
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            int iCell = i + iSquare * 3;
                            int jCell = j + jSquare * 3;
                            int kCell = i + j * 3;
                            //logger.Log("Adding cell " + iCell + "/" + jCell + " to position " + kCell);
                            cells[kCell] = GetCell(iCell, jCell);
                        }
                    }
                    SolveCells(cells);
                }
            }

            // return true if all cells solved
            var solved = true;
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    if (GetCell(i, j).value == 0) solved = false;
            return solved;
        }

        public void SolveCells(Cell[] cells)
        {
            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i].value > 0)
                    for (int j = 0; j < cells.Length; j++)
                        if (j != i)
                            cells[j].Eliminate(cells[i].value);
            }
        }
    }
}
