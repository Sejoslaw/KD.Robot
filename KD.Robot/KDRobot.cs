using KD.Robot.Commands;
using System.Collections.Generic;
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

        /// <summary>
        /// Dictionary which hold additional variables for this Robot.
        /// It was made on purpose for plugins / additional commands to add various variables to Robot.
        /// Variable naming convention: "Plugin_PluginName_VariableName"
        /// </summary>
        public IDictionary<string, object> Variables { get; private set; }

        public KDRobot()
        {
            // Set default Process
            this.CurrentProcess = Process.GetCurrentProcess();
            // Set variables
            this.Variables = new Dictionary<string, object>();
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