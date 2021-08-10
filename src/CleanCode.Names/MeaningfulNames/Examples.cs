using System.Collections.Generic;

namespace CleanCode.Names.MeaningfulNames
{
    public class Examples
    {
        #region Helper properties.
        /// <summary>
        /// Helper properties.
        /// </summary>
        public List<object> GameBoard;
        public List<object> SomeList;
        public int STATUS_VALUE;
        public const int FLAGGED = 4;
        #endregion Helper properties.

        /// <summary>
        /// A bad choice as this name doesn't have an expressive meaning.
        /// </summary>
        public int D;

        /// <summary>
        /// Good choices as these ones have a name which express their meaning.
        /// </summary>
        public int ElapsedTimeInDays;
        public int DaysSinceCreation;
        public int DaysSinceModification;
        public int FileAgeInDays;

        /// <summary>
        /// Bad choice. It have an high implicitness.
        /// For example, we don't know what comes within 'someList'.
        /// Also, we don't know what is the meaning of 4, as well as the importance of the item at index 0.
        /// </summary>
        public List<int[]> GetThem()
        {
            List<int[]> list1 = new List<int[]>();

            foreach (int[] i in SomeList)
                if (i[0] == 4)
                    list1.Add(i);
            return list1;
        }
        
        /// <summary>
        /// Let's imagine that we are working with a minefield board. Each square is represented by a simple vector. And then, we realize that:
        ///     - the 0 index stores a position;
        ///     - the number 4 represents some 'flagged' rule;
        ///     - and 'someList' is a cell list called GameBoard.
        /// </summary>
        public List<int[]> GetFlaggedCells()
        {
            List<int[]> flaggedCells = new List<int[]>();

            foreach (int[] cell in GameBoard)
                if (cell[STATUS_VALUE] == FLAGGED)
                    flaggedCells.Add(cell);
            return flaggedCells;
        }

        /// <summary>
        /// Instead of continue using an int array, we can create a class for the cells, which can have a function that represents if the cell was flagged or not.
        /// </summary>
        public List<Cell> GetFlaggedCellsImproved()
        {
            List<Cell> flaggedCells = new List<Cell>();

            foreach (Cell cell in GameBoard)
                if (cell.IsFlagged)
                    flaggedCells.Add(cell);
            return flaggedCells;
        }
    }

    public class Cell
    {
        public bool IsFlagged { get; }
    }
}