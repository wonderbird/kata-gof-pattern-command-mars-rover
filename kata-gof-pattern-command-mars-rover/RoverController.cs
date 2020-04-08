using System.Collections.Generic;

namespace kata_gof_pattern_command_mars_rover
{
    public class RoverController
    {
        private Position _position;
        private Plateau _plateau;

        public string ProcessInput(string input)
        {
            try
            {
                _position = PositionParser.Parse(input);
                _plateau = PlateauParser.Parse(input);

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