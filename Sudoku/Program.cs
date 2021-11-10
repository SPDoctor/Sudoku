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
                string sGrid = @"007000400
040020070
800307009
013070290
084903560
059060130
300104006
060030040
001000900
";
                grid.Load(sGrid);
            }
            // TODO: call Solve iteratively until returns true
            grid.Solve();
            WriteLine(grid.ToString());
        }
    }
}
