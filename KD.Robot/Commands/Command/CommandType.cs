using System.Windows.Forms;

namespace KD.Robot.Commands.Command
{
    /// <summary>
    /// Command Type is used to simulate input from keyboard.
    /// </summary>
    class CommandType : CommandBase
    {
        public override string GetCommandKeyWord()
        {
            return CommandDictionary.CommandTypeKeyWord;
        }

        public override void ExecCommand(KDRobot robot, object[] args)
        {
            string text = CutText(args[0].ToString()); // Text which should be typed
            SendKeys.SendWait(text);
        }

        private string CutText(string commandInput)
        {
            return commandInput.Substring(0, commandInput.Length - 1);
        }
    }
}