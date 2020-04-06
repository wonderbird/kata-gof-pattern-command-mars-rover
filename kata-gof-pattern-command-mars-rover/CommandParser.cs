using System;
using System.Collections.Generic;
using System.Linq;

namespace kata_gof_pattern_command_mars_rover
{
    public class CommandParser
    {
        private readonly List<ICommandFactory> _availableCommands = new List<ICommandFactory>
        {
            new MoveCommand(),
            new TurnLeftCommand(),
            new TurnRightCommand(),
        };

        public Command Parse(char commandChar)
        {
            var factory = FindCommandFactory(commandChar);

            if (factory == null)
            {
                throw new InputParseException(string.Format(InputParseException.InvalidCommandMessage, commandChar));
            }

            var command = factory.Create();
            return command;
        }

        private ICommandFactory FindCommandFactory(char commandChar)
        {
            return _availableCommands.FirstOrDefault(x => x.CommandName == commandChar);
        }
    }
}