using KD.Robot.Commands;
using System.Diagnostics;

namespace KD.Robot
{
    /// <summary>
    /// Represents Robot itself.
    /// </summary>
    public class KDRobot
    {
        /// <summary>
        /// Process on which this Robot is currently working.
        /// </summary>
        public Process CurrentProcess { get; set; }

        public KDRobot()
        {
            // Set default Process
            this.CurrentProcess = Process.GetCurrentProcess();
        }

        /// <summary>
        /// Executes given commands on this Robot instance.
        /// </summary>
        /// <param name="commands"></param>
        public void Execute(string commands)
        {
            // Parse given string to commands
            var commandArr = CommandParser.Parse(commands);
            // Execute each command one-by-one
            foreach (var comm in commandArr) comm.ExecuteCommand(this);
        }
    }
}