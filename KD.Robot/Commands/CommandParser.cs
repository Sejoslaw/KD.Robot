using System.Collections.Generic;

namespace KD.Robot.Commands
{
    /// <summary>
    /// Class which is used to Parse commands.
    /// </summary>
    public class CommandParser
    {
        private CommandParser()
        {
        }

        /// <summary>
        /// Returns parsed commands.
        /// </summary>
        /// <param name="commands"></param>
        /// <returns></returns>
        public static List<CommandExecuter> Parse(string commands)
        {
            var commandExecs = new List<CommandExecuter>();

            var singleCommands = commands.Split('\n');
            foreach (var singleCommand in singleCommands) // Parse each Command
            {
                if (singleCommand.Equals("")) break;

                var parts = singleCommand.Split(' ');
                var commandKeyWord = parts[0];
                var commandArgs = singleCommand.Substring(commandKeyWord.Length + 1);

                var command = CommandRegistry.GetCommandByKeyWord(commandKeyWord);
                var args = new object[] { commandArgs };

                commandExecs.Add(new CommandExecuter() { Command = command, Arguments = args });
            }
            return commandExecs;
        }
    }
}