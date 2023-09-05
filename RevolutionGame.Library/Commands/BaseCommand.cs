using RevolutionGame.Library.Commands.ICommands;
using RevolutionGame.Library.Enums;
using RevolutionGame.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RevolutionGame.Library.Commands
{
    public abstract class BaseCommand : IBaseCommand
    {
        protected readonly IPiece _piece;
        public BaseCommand(IPiece piece)
        {
            ValidatePiece(piece);
            _piece = piece;
        }
        protected CardinalDirection MinDirection { get; } = CardinalDirection.North;
        protected CardinalDirection MaxDirection { get; } = CardinalDirection.West;

        public virtual bool CanExecuteCommand() => true;

        public abstract void ExecuteCommand();

        protected void ValidatePiece(IPiece piece)
        {
            if (piece is null)
                throw new ArgumentNullException(nameof(piece));
        }
    }
}
