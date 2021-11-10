using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    public class Grid
    {
        Cell[,] grid;
        int cols, rows;

        public Grid(int cols, int rows)
        {
            this.cols = cols;
            this.rows = rows;
            grid = new Cell[cols, rows];
            for (int j = 0; j < rows; j++)
                for (int i = 0; i < cols; i++)
                    grid[i, j] = new Cell(i + 1);
        }

        public override string ToString()
        {
            /* print out the grid */
            StringBuilder output = new StringBuilder();
            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < cols; i++)
                {
                    output.Append(grid[i, j].value);
                    output.Append(" ");
                }
                output.Append("\r\n");
            }
            output.Append("\r\n");
            return output.ToString();
        }

        public void Load(string sGrid)
        {

        }
    }
}
