using System.Diagnostics;

namespace KD.Robot.Commands.Command
{
    /// <summary>
    /// Process Command is used to start new process
    /// </summary>
    class CommandProcess : ICommand
    {
        public string GetCommandKeyWord()
        {
            return CommandDictionary.CommandProcessKeyWord;
        }

        public void ExecuteCommand(KDRobot robot, object[] args)
        {
            if (robot == null || args == null) return;
            if (args.Length < 0) return;
            if (!(args[0] is string)) return;

            var processName = GetProcessName(args[0] as string);
            StartProcess(robot, processName);
        }

        private string GetProcessName(string processNameWithStars)
        {
            var ret = processNameWithStars.Split('*');
            return ret[1];
        }

        private void StartProcess(KDRobot robot, string processName)
        {
            Process process = Process.Start(processName);
        }
    }
}