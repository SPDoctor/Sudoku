using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        public SudokuGrid grid;

        [TestInitialize]
        public void Initialise()
        {
            grid = new SudokuGrid();
        }

        [TestMethod]
        public void TestSolveCells_EmptyArray()
        {
            Cell[] cells = new Cell[9];
            for (int i = 0; i < 9; i++) cells[i] = new Cell(0);

            grid.SolveCells(cells);

            for (int i = 0; i < 9; i++)
            {
                Assert.AreEqual(0, cells[i].value);
            }
        }


        [TestMethod]
        public void TestSolveCells_Array_with_one_value()
        {
            Cell[] cells = new Cell[9];
            for (int i = 0; i < 9; i++) cells[i] = new Cell(0);
            cells[2].value = 7;

            grid.SolveCells(cells);

            for (int i = 0; i < 9; i++)
            {
                if (i != 2) Assert.AreEqual(0, cells[i].value);
            }
            Assert.AreEqual(7, cells[2].value);
        }

        [TestMethod]
        public void TestSolveCells_Array_with_all_but_one_value()
        {
            Cell[] cells = new Cell[9];
            for (int i = 0; i < 9; i++) cells[i] = new Cell(i+1);
            cells[2].value = 0;

            grid.SolveCells(cells);

            Assert.AreEqual(3, cells[2].value);
        }

    }
}
