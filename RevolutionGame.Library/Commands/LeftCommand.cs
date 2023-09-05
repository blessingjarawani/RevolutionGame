using RevolutionGame.Library.Commands.ICommands;
using RevolutionGame.Library.Interfaces;
using System;

namespace RevolutionGame.Library.Commands
{
    public class LeftCommand : BaseCommand, ILeftCommand
    {  
        public LeftCommand(IPiece piece) : base(piece)
        {
        }

        public override void ExecuteCommand() =>
            _piece.CardinalDirection = _piece.CardinalDirection == MinDirection ? _piece.CardinalDirection = MaxDirection : _piece.CardinalDirection -= 1;

    }
}
