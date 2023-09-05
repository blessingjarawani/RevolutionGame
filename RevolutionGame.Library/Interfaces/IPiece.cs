
using RevolutionGame.Library.Enums;

namespace RevolutionGame.Library.Interfaces
{
    public interface IPiece
    {
        CardinalDirection CardinalDirection { get; set; }
        int XPosition { get; set; }
        int YPosition { get; set; }

    }
}
