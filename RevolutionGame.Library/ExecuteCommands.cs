using RevolutionGame.Library.Commands.ICommands;
using RevolutionGame.Library.Enums;
using RevolutionGame.Library.Interfaces;
using System;
using System.Drawing;
using System.Linq;

namespace RevolutionGame.Library
{
    public class ExecuteCommands : IExcecuteCommands
    {
        private readonly IPiece _piece;
        private readonly IMoveCommand _move;
        private readonly IRightCommand _rightCommand;
        private ILeftCommand _leftComand;

        public ExecuteCommands(IPiece piece, IMoveCommand move, ILeftCommand leftCommand, IRightCommand rightCommand)
        {
            _piece = piece;
            _move = move;
            _rightCommand = rightCommand;
            _leftComand = leftCommand;
        }

        public void TurnLeft()
        {
            ExecuteCommand(_leftComand);
        }

        public void TurnRight()
        {
            ExecuteCommand(_rightCommand);
        }

        public void Move()
        {
            ExecuteCommand(_move);
        }

        private void ExecuteCommand(IBaseCommand command)
        {
            if (!command.CanExecuteCommand())
                return;

            command.ExecuteCommand();
        }


        public void ExecuteCommand(string commands)
        {
            foreach (char command in commands.ToUpper())
            {
                if (command == 'M')
                {
                    Move();
                }
                else if (command == 'L')
                {
                    TurnLeft();
                }
                else if (command == 'R')
                {
                    TurnRight();
                }
                else throw new ArgumentException();
            }


        }

    }
}
