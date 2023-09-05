using RevolutionGame.Library.Commands.ICommands;
using RevolutionGame.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionGame.Library.Commands
{
    public class RightCommand : BaseCommand, IRightCommand
    {
     
        public RightCommand(IPiece piece) : base(piece)
        {
          
        }


        public override void ExecuteCommand() =>
            _piece.CardinalDirection = _piece.CardinalDirection == MaxDirection ? _piece.CardinalDirection = MinDirection : _piece.CardinalDirection += 1;

    }
}
