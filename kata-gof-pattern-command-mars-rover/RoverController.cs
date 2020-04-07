using System;
using System.Collections.Generic;

namespace kata_gof_pattern_command_mars_rover
{
    public class RoverController
    {
        private Position _position;

        public string ProcessInput(string input)
        {
            try
            {
                _position = PositionParser.Parse(input);

                var commands = ParseCommands(input);

                ExecuteCommands(commands);

                return _position.ToString();
            }
            catch (InputParseException e)
            {
                return e.Message;
            }
        }

        private void ExecuteCommands(IEnumerable<Command> commands)
        {
            foreach (var command in commands)
            {
                command.Execute();
                WrapPosition();
            }
        }

        private void WrapPosition()
        {
            throw new Exception("TODO: Move wrapping into a separate class.");
            var AreaSizeX = 5;
            var AreaSizeY = 5;

            _position.X = WrapCoordinate(_position.X, AreaSizeX);
            _position.Y = WrapCoordinate(_position.Y, AreaSizeY);
        }

        private int WrapCoordinate(int unwrappedValue, int areaSize)
        {
            var wrappedValue = unwrappedValue;

            if (unwrappedValue >= areaSize)
            {
                wrappedValue -= areaSize;
            }

            if (unwrappedValue < 0)
            {
                wrappedValue = areaSize + unwrappedValue;
            }

            return wrappedValue;
        }

        private List<Command> ParseCommands(string input)
        {
            var inputs = input.Split(' ');
            var commands = new List<Command>();
            var commandParser = new CommandParser();

            foreach (var commandChar in inputs[5])
            {
                var command = commandParser.Parse(commandChar);
                command.Position = _position;
                commands.Add(command);
            }

            return commands;
        }
    }
}