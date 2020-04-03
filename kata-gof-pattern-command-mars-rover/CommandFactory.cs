using System.Collections.Generic;

namespace kata_gof_pattern_command_mars_rover
{
    public class CommandFactory
    {
        private readonly Position _position;

        public CommandFactory(Position position)
        {
            _position = position;
        }

        public Command Create(char commandChar)
        {
            var commandCharToCommand = new Dictionary<char, Command>
            {
                {'M', new MoveCommand()},
                {'R', new TurnRightCommand()},
                {'L', new TurnLeftCommand() }
            };

            var command = commandCharToCommand[commandChar];
            command.Position = _position;

            return command;
        }
    }
}