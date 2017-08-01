using System.Collections.Generic;
using System.Linq;

namespace KD.Robot.Commands
{
    /// <summary>
    /// Holds data about all registered Commands.
    /// </summary>
    public class CommandRegistry
    {
        /// <summary>
        /// _commands is the Set which contains all data about all currently registered Commands.
        /// </summary>
        private static ISet<ICommand> _commands = null;
        public static ISet<ICommand> Commands
        {
            get
            {
                if (_commands == null) _commands = CommandLoader.LoadCommands();
                return _commands;
            }
        }

        /// <summary>
        /// Returns Command by it KeyWord.
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        public static ICommand GetCommandByKeyWord(string keyWord)
        {
            return Commands.FirstOrDefault(comm => comm.GetCommandKeyWord().Equals(keyWord));
        }
    }
}