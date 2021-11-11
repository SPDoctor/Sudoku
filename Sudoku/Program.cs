using System;
using System.Collections.Generic;
using System.Reflection;
using static System.Console;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new SudokuGrid(new ConsoleLogger());

            // Reflection:
            var t = grid.GetType();
            Write("Created grid of type " + t + " with constructors: ");
            ConstructorInfo[] ci = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            foreach (MemberInfo m in ci) Write("  " + m);
            WriteLine();
            WriteLine();

            if (args.Length >= 1)
            {
                string sGrid = @"230000004
461020070
700301000
000104000
680030001
005098002
000406750
040003018
010005009
";
                grid.Load(sGrid);
                WriteLine("Loaded grid:");
                WriteLine(grid.ToString());
            }
            // TODO: call Solve iteratively until returns true
            while (true)
            {
                grid.Solve();
                WriteLine(grid.ToString());
                ReadLine();
            }
        }
    }
}
