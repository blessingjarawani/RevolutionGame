using RevolutionGame.Library.Commands.ICommands;
using RevolutionGame.Library.Enums;
using RevolutionGame.Library.Interfaces;
using System;

namespace RevolutionGame.Library.Commands
{
    public class MoveCommand : BaseCommand, IMoveCommand
    {

        private readonly IBoard _board;
        public MoveCommand(IPiece piece, IBoard board) : base(piece)
        {
            _board = board;
        }

        public override void ExecuteCommand()
        {
            if (!CanExecuteCommand())
                throw new InvalidOperationException();

            switch (_piece.CardinalDirection)
            {
                case CardinalDirection.South:
                    _piece.YPosition -= 1;
                    break;
                case CardinalDirection.East:
                    _piece.XPosition += 1;
                    break;
                case CardinalDirection.North:
                    _piece.YPosition += 1;
                    break;
                case CardinalDirection.West:
                    _piece.XPosition -= 1;
                    break;

            }
        }
        public override bool CanExecuteCommand()
        {
            switch (_piece.CardinalDirection)
            {
                case CardinalDirection.South:
                    return _piece.YPosition > 0;
                case CardinalDirection.West:
                    return _piece.XPosition > 0;
                case CardinalDirection.North:
                    return _piece.YPosition + 1 < _board.Rows;
                case CardinalDirection.East:
                    return _piece.XPosition + 1 < _board.Columns;

            }

            return false;
        }


    }
}
