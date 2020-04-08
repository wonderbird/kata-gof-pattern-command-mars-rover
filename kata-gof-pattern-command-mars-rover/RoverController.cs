using System.Collections.Generic;

namespace kata_gof_pattern_command_mars_rover
{
    public class RoverController
    {
        private const int NumberOfInputFields = 5;

        private Position _position;
        private Plateau _plateau;

        public string ProcessInput(string input)
        {
            try
            {
                var inputFields = input.Split(' ');
                ValidateNumberOfInputFields(inputFields);

                _plateau = PlateauParser.Parse(inputFields);
                _position = PositionParser.Parse(inputFields);

                var commands = ParseCommands(input);

                ExecuteCommands(commands);

                return _position.ToString();
            }
            catch (InputParseException e)
            {
                return e.Message;
            }
        }

        private static void ValidateNumberOfInputFields(string[] inputFields)
        {
            if (inputFields.Length < NumberOfInputFields)
                throw new InputParseException(InputParseException.InvalidPositionMessage);
        }

        private void ExecuteCommands(IEnumerable<Command> commands)
        {
            foreach (var command in commands)
            {
                command.Execute();
                _position = _plateau.WrapPosition(_position);
            }
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