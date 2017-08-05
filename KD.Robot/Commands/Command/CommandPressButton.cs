namespace KD.Robot.Commands.Command
{
    /// <summary>
    /// Command Press Button should simulate pressing buttons like F10, Shift, Enter, etc.
    /// </summary>
    class CommandPressButton : CommandBase
    {
        public override string GetCommandKeyWord()
        {
            return CommandDictionary.CommandPressButtonKeyWord;
        }

        public override void ExecCommand(KDRobot robot, object[] args)
        {
        }
    }
}