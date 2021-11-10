using System;
using System.Collections.Generic;
using static System.Console;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new SudokuGrid();
            if(args.Length >= 1)
            {
                string sGrid = "";
                grid.Load(sGrid);
            }
            WriteLine(grid.ToString());
        }
    }
}
