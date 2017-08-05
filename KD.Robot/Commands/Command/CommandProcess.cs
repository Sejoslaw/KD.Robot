using System.Diagnostics;

namespace KD.Robot.Commands.Command
{
    /// <summary>
    /// Process Command is used to start new process
    /// </summary>
    class CommandProcess : CommandBase
    {
        public override string GetCommandKeyWord()
        {
            return CommandDictionary.CommandProcessKeyWord;
        }

        public override void ExecCommand(KDRobot robot, object[] args)
        {
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
            robot.CurrentProcess = Process.Start(processName);
        }
    }
}