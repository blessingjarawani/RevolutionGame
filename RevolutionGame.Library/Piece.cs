using RevolutionGame.Library.Enums;
using RevolutionGame.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionGame.Library
{
    public class Piece : IPiece
    {
        public CardinalDirection CardinalDirection { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public Piece(int xposition = 0, int yposition = 0)
        {
            XPosition = xposition;
            YPosition = yposition;
        }

       
    }
}
