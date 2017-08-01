using System;
using System.Collections.Generic;
using System.Reflection;

namespace KD.Robot.Commands
{
    /// <summary>
    /// Class which is used as a Loader for all Commands.
    /// </summary>
    class CommandLoader
    {
        /// <summary>
        /// Returns a Set with all loaded Commands.
        /// </summary>
        /// <returns></returns>
        public static ISet<ICommand> LoadCommands()
        {
            ISet<ICommand> commandsSet = new HashSet<ICommand>();

            foreach (ICommand comm in GetLocalCommands()) commandsSet.Add(comm);
            //foreach (ICommand comm in GetPluginCommands()) commandsSet.Add(comm); // For future use when Plugins will be enabled.

            return commandsSet;
        }

        /// <summary>
        /// Load local commands.
        /// </summary>
        /// <returns></returns>
        private static ISet<ICommand> GetLocalCommands()
        {
            ISet<ICommand> commandSet = new HashSet<ICommand>();

            // ICommand type
            Type commandType = typeof(ICommand);
            // Assembly which contains ICommand
            Assembly commandAssembly = commandType.Assembly;
            // All types in current Assembly
            var types = commandAssembly.GetTypes();

            foreach (Type type in types)
            {
                if (commandType.IsAssignableFrom(type))
                {
                    try
                    {
                        ICommand newCommandInstance = (ICommand)Activator.CreateInstance(type);
                        commandSet.Add(newCommandInstance);
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            return commandSet;
        }
    }
}