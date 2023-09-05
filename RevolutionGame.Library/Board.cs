using RevolutionGame.Library.Interfaces;
using System;

namespace RevolutionGame.Library
{
    public class Board : IBoard
    {
        public int Columns { get; }
        public int Rows { get; }

        public Board(int rows = 5, int columns = 5)
        {
            if (rows <= 0 || columns <= 0)
                throw new ArgumentException("Board columns or rows must be greater than 0.");

            Columns = columns;
            Rows = rows;
        }

    }
      
}
