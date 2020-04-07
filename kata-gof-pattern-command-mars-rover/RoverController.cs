using System.Collections.Generic;

namespace kata_gof_pattern_command_mars_rover
{
    public class RoverController
    {

        public string ProcessInput(string input)
        {
            try
            {
                var position = PositionParser.Parse(input);

                var commandParser = new CommandParser();

                var inputs = input.Split(' ');
                var commands = new List<Command>();
                foreach (var commandChar in inputs[5])
                {
                    var command = commandParser.Parse(commandChar);
                    command.Position = position;
                    commands.Add(command);
                }

                commands.ForEach(c => c.Execute());

                return position.ToString();
            }
            catch (InputParseException e)
            {
                return e.Message;
            }
        }
    }
}