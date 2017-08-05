using System.Diagnostics;

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
            var processName = GetProcessName(args[0] as string);
            SwitchProcess(robot, processName);
        }

        private string GetProcessName(string processNameWithStars)
        {
            var ret = processNameWithStars.Split('*');
            return ret[1];
        }

        private void SwitchProcess(KDRobot robot, string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);

            if (processes.Length < 1) return;

            Process process = processes[0];
            bool set = WinApi.User32.SetForegroundWindow(process.Handle);
            if (set) robot.CurrentProcess = process;
        }
    }
}
