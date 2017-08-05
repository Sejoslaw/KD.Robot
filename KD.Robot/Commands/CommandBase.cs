namespace KD.Robot.Commands
{
    /// <summary>
    /// Base of all Commands.
    /// </summary>
    public abstract class CommandBase : ICommand
    {
        public abstract string GetCommandKeyWord();

        public abstract void ExecuteCommand(KDRobot robot, object[] args);
    }
}
