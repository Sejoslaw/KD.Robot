namespace KD.Robot.Commands
{
    /// <summary>
    /// Describes a single Command used to program Robot.
    /// Commands should NOT have any constructor.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Returns the unique KeyWord for this Command.
        /// </summary>
        /// <returns></returns>
        string GetCommandKeyWord();

        /// <summary>
        /// Executes this Command.
        /// This Command is executed by specified Robot.
        /// </summary>
        /// <param name="robot"></param>
        void ExecuteCommand(KDRobot robot, object[] args);
    }
}