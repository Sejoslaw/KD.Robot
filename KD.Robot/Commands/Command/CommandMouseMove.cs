using System;
using System.Drawing;

namespace KD.Robot.Commands.Command
{
    /// <summary>
    /// Mouse Move command is used to move Mouse to specified position.
    /// </summary>
    class CommandMouseMove : CommandBase
    {
        public override string GetCommandKeyWord()
        {
            return CommandDictionary.CommandMouseMoveKeyWord;
        }

        public override void ExecCommand(KDRobot robot, object[] args)
        {
            string[] sargs = toStringArgs(args);
            Point cursorPosition = new Point(Int32.Parse(sargs[0]), Int32.Parse(sargs[1]));
            MoveCursor(robot, ref cursorPosition);
        }

        private void MoveCursor(KDRobot robot, ref Point cursorPosition)
        {
            WinApi.User32.ClientToScreen(robot.CurrentProcess.Handle, ref cursorPosition);
            WinApi.User32.SetCursorPos(cursorPosition.X, cursorPosition.Y);
        }
    }
}