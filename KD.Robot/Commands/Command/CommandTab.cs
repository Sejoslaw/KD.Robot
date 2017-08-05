using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace KD.Robot.Commands.Command
{
    /// <summary>
    /// Tab Command is used to change between windows.
    /// </summary>
    class CommandTab : CommandBase
    {
        public override string GetCommandKeyWord()
        {
            return CommandDictionary.CommandTabKeyWord;
        }

        public override void ExecCommand(KDRobot robot, object[] args)
        {
            var windowName = GetProcessName(args[0] as string);
            SwitchProcess(robot, windowName);
        }

        private string GetProcessName(string processNameWithStars)
        {
            var ret = processNameWithStars.Split('*');
            return ret[1];
        }

        private void SwitchProcess(KDRobot robot, string windowName)
        {
            IEnumerable<Process> process = Process.GetProcesses().Where(p => p.MainWindowTitle.Equals(windowName));

            if (process.Count() < 1) return; // Wrong title

            Process wantedProcess = process.ToList().ElementAt(0);
            robot.CurrentProcess = wantedProcess;
        }
    }
}