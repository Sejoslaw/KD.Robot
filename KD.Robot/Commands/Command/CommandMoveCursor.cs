using System;
using System.Drawing;

namespace KD.Robot.Commands.Command
{
    class CommandMoveCursor : CommandBase
    {
        public override string GetCommandKeyWord()
        {
            return CommandDictionary.CommandMoveCursorKeyWord;
        }

        public override void ExecuteCommand(KDRobot robot, object[] args)
        {
            if (robot == null || args == null) return;
            if (args.Length < 0) return;
            if (!(args[0] is string)) return;

            string[] sargs = args[0].ToString().Split(' ');

            Point cursorPosition = new Point(Int32.Parse(sargs[0]), Int32.Parse(sargs[1]));

            WinApi.User32.ClientToScreen(robot.CurrentProcess.Handle, ref cursorPosition);
            WinApi.User32.SetCursorPos(cursorPosition.X, cursorPosition.Y);
        }
    }
}