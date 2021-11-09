using System;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[9,9];
            for(int j=0;j<9;j++)
                for(int i=0;i<9;i++)
                    grid[i,j] = i;

            /* print out the grid */
            for (int j = 0; j < 9; j++)
                for (int i = 0; i < 9; i++)
            {
                Console.Write(grid[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}
