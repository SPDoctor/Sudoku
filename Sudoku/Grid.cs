using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    public class Grid
    {
        int[,] grid;

        public Grid()
        {
            grid = new int[9, 9];
            for (int j = 0; j < 9; j++)
                for (int i = 0; i < 9; i++)
                    grid[i, j] = i + 1;
        }

        public override string ToString()
        {
            /* print out the grid */
            string output = "";
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    output += grid[i, j] + " ";
                }
                output += "\r\n";
            }
            output += "\r\n";
            return output;
        }
    }
}
