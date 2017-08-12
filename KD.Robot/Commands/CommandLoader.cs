using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace KD.Robot.Commands
{
    /// <summary>
    /// Class which is used as a Loader for all Commands.
    /// </summary>
    class CommandLoader
    {
        /// <summary>
        /// Name of a directory which contains additional plugins.
        /// </summary>
        private static string PLUGINS_FOLDER = "plugins";

        /// <summary>
        /// Returns a Set with all loaded Commands.
        /// </summary>
        /// <returns></returns>
        public static ISet<ICommand> LoadCommands()
        {
            ISet<ICommand> commandsSet = new HashSet<ICommand>();

            foreach (ICommand comm in GetLocalCommands()) commandsSet.Add(comm);
            foreach (ICommand comm in GetPluginsCommands()) commandsSet.Add(comm);

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
            // Load local commands
            return LoadCommandsFromAssembly(commandType.Assembly);
        }

        /// <summary>
        /// Load commands from plugin files.
        /// </summary>
        /// <returns></returns>
        private static ISet<ICommand> GetPluginsCommands()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path += "/" + PLUGINS_FOLDER;

            DirectoryInfo pluginDir;
            if (!Directory.Exists(path)) pluginDir = Directory.CreateDirectory(path);
            else pluginDir = new DirectoryInfo(path);

            ISet<ICommand> commandsOut = new HashSet<ICommand>();

            foreach (FileInfo pluginFile in pluginDir.GetFiles())
            {
                try
                {
                    Assembly assembly = Assembly.LoadFrom(pluginFile.DirectoryName);
                    ISet<ICommand> commands = LoadCommandsFromAssembly(assembly);
                    foreach (ICommand command in commands) commandsOut.Add(command);
                }
                catch (Exception e)
                {
                    throw new Exception("Error while loading command from plugin assembly: " + pluginFile.ToString());
                }
            }

            return commandsOut;
        }

        /// <summary>
        /// Load commands from single given Assembly.
        /// </summary>
        /// <param name="assembly"></param>
        /// <returns></returns>
        private static ISet<ICommand> LoadCommandsFromAssembly(Assembly assembly)
        {
            ISet<ICommand> commandSet = new HashSet<ICommand>();

            // All types in current Assembly
            var types = assembly.GetTypes();

            foreach (Type type in types)
            {
                if (typeof(ICommand).IsAssignableFrom(type) && !type.IsAbstract)
                {
                    try
                    {
                        ICommand newCommandInstance = (ICommand)Activator.CreateInstance(type);
                        commandSet.Add(newCommandInstance);
                    }
                    catch (Exception)
                    {
                        throw new Exception("Error while loading command: " + type.ToString());
                    }
                }
            }

            return commandSet;
        }
    }
}