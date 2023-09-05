using NUnit.Framework;
using RevolutionGame.Library;
using RevolutionGame.Library.Commands;
using RevolutionGame.Library.Commands.ICommands;
using RevolutionGame.Library.Enums;
using RevolutionGame.Library.Interfaces;

namespace RevolutionGame.Tests
{
    public class GameTests
    {
        private IPiece piece;
        private IMoveCommand move;
        private IBoard board;
        private ILeftCommand leftCommand;
        private IRightCommand rightCommand;
        private IExcecuteCommands excecuteCommands;

        [SetUp]
        public void Setup()
        {
            piece = new Piece();
            board = new Board();
            move = new MoveCommand(piece, board);
            leftCommand = new LeftCommand(piece);
            rightCommand = new RightCommand(piece);
        }

        [Test]
        public void Test_WhenInput_IS_MMMMM()
        {
            excecuteCommands = new ExecuteCommands(piece, move, leftCommand, rightCommand);
            excecuteCommands.ExecuteCommand("MMMMM");
            Assert.AreEqual(0, piece.XPosition);
            Assert.AreEqual(4, piece.YPosition);
            Assert.AreEqual(piece.CardinalDirection, CardinalDirection.North);
        }

        [Test]
        public void Test_WhenInput_IS_MRMLMRM()
        {
            excecuteCommands = new ExecuteCommands(piece, move, leftCommand, rightCommand);
            excecuteCommands.ExecuteCommand("MRMLMRM");
            Assert.AreEqual(2, piece.XPosition);
            Assert.AreEqual(2, piece.YPosition);
            Assert.AreEqual(piece.CardinalDirection, CardinalDirection.East);
        }

        [Test]
        public void Test_WhenInput_IS_RMMMLMM()
        {
            excecuteCommands = new ExecuteCommands(piece, move, leftCommand, rightCommand);
            excecuteCommands.ExecuteCommand("RMMMLMM");
            Assert.AreEqual(3, piece.XPosition);
            Assert.AreEqual(2, piece.YPosition);
            Assert.AreEqual(piece.CardinalDirection, CardinalDirection.North);
        }


    }
}