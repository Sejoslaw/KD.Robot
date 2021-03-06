﻿namespace KD.Robot.Commands
{
    /// <summary>
    /// Base of all Commands.
    /// </summary>
    public abstract class CommandBase : ICommand
    {
        public abstract string GetCommandKeyWord();

        public void ExecuteCommand(KDRobot robot, object[] args)
        {
            if (robot == null || args == null) return;
            if (args.Length < 0) return;
            if (!(args[0] is string)) return;

            ExecCommand(robot, args);
        }

        /// <summary>
        /// Simple args[0] split.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        protected string[] ToStringArgs(object[] args)
        {
            return args[0].ToString().Split(' ');
        }

        /// <summary>
        /// Execute command after first check for errors.
        /// </summary>
        /// <param name="robot"></param>
        /// <param name="args"></param>
        public abstract void ExecCommand(KDRobot robot, object[] args);
    }
}