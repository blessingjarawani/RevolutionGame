namespace RevolutionGame.Library.Interfaces
{
    public interface IExcecuteCommands
    {
        void TurnLeft();
        void TurnRight();
        void Move();
        void ExecuteCommand(string commands);

    }
}
