namespace KD.Robot.Commands
{
    /// <summary>
    /// Represents a single Command execute.
    /// </summary>
    public class CommandExecuter
    {
        /// <summary>
        /// Command which should be executed.
        /// </summary>
        public ICommand Command { get; set; }
        /// <summary>
        /// Arguments for this Command.
        /// </summary>
        public object[] Arguments { get; set; }

        /// <summary>
        /// Execute holding Command with given Robot.
        /// </summary>
        /// <param name="robot"></param>
        public void ExecuteCommand(KDRobot robot)
        {
            Command.ExecuteCommand(robot, Arguments);
        }
    }
}