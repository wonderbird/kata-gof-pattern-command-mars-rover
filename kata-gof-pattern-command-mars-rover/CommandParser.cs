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
            new InvalidCommand()
        };

        public Command Parse(char commandChar)
        {
            var factory = FindCommandFactory(commandChar);
            var command = factory.Create();
            return command;
        }

        private ICommandFactory FindCommandFactory(char commandChar)
        {
            return _availableCommands.First(x => x.CommandName == commandChar);
        }
    }
}