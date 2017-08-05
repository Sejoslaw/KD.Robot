using KD.Robot.WinApi;
using System;

namespace KD.Robot.Commands.Command
{
    /// <summary>
    /// Mouse Click command is used to simulate Mouse clicking specified button.
    /// </summary>
    class CommandMouseClick : CommandBase
    {
        public override string GetCommandKeyWord()
        {
            return CommandDictionary.CommandMouseClickKeyWord;
        }

        public override void ExecCommand(KDRobot robot, object[] args)
        {
            string[] sargs = toStringArgs(args);
            string button = sargs[0]; // L - left, R - right, M - middle
            int numberOfClicks = Int32.Parse(sargs.Length < 2 ? "1" : sargs[1]); // number of clicks

            for (int i = 0; i < numberOfClicks; ++i) MouseButtonClick(button);
        }

        private void MouseButtonClick(string button)
        {
            if (button.Equals("L")) // Left Mouse Button was clicked
            {
                WinApi.User32.mouse_event((uint)MouseEventFlags.LEFTDOWN, 0, 0, 0, UIntPtr.Zero);
                WinApi.User32.mouse_event((uint)MouseEventFlags.LEFTUP, 0, 0, 0, UIntPtr.Zero);
            }
            else if (button.Equals("R")) // Right Mouse Button was clicked
            {
                WinApi.User32.mouse_event((uint)MouseEventFlags.RIGHTDOWN, 0, 0, 0, UIntPtr.Zero);
                WinApi.User32.mouse_event((uint)MouseEventFlags.RIGHTUP, 0, 0, 0, UIntPtr.Zero);
            }
            else if (button.Equals("M")) // Middle Mouse Button was clicked
            {
                WinApi.User32.mouse_event((uint)MouseEventFlags.MIDDLEDOWN, 0, 0, 0, UIntPtr.Zero);
                WinApi.User32.mouse_event((uint)MouseEventFlags.MIDDLEUP, 0, 0, 0, UIntPtr.Zero);
            }
        }
    }
}