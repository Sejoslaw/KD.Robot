using System;
using System.Threading;

namespace KD.Robot.Commands.Command
{
    class CommandSleep : CommandBase
    {
        public override void ExecCommand(KDRobot robot, object[] args)
        {
            var sargs = this.ToStringArgs(args);
            var timeout = sargs[0];
            try
            {
                var parsedTimeout = Int32.Parse(timeout);
                Thread.Sleep(parsedTimeout);
            }
            catch(Exception)
            {
            }
        }

        public override string GetCommandKeyWord()
        {
            return CommandDictionary.CommandSleepKeyWord;
        }
    }
}