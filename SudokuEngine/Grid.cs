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
            output.Append("-----------------------\r\n");
            for (int j = 0; j < rows; j++)
            {
                output.Append("| ");
                for (int i = 0; i < cols; i++)
                {
                    if (grid[i, j].value > 0)
                    {
                        output.Append(grid[i, j].value);
                    }
                    else
                    {
                        output.Append(" ");
                    }
                    output.Append(" ");
                    if ((i - 2) % 3 == 0) output.Append("|");
                }
                output.Append("\r\n");
                if((j-2)%3 == 0) output.Append("|---------------------|\r\n");
            }
            output.Append("\r\n");
            return output.ToString();
        }

        public Cell[,] getGrid()
        {
            return grid;
        }


        public void Load(string sGrid)
        {
            string[] rows = sGrid.Trim().Split("\n");
            int j = 0;
            foreach (string row in rows)
            {
                int i = 0;
                foreach (char ch in row)
                {
                    grid[i, j].value = int.Parse(ch.ToString());
                    ++i;
                }
                ++j;
            }
        }

        public Cell GetCell(int col, int row)
        {
            return grid[col, row];
        }
    }
}
