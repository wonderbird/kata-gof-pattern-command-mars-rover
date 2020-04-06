namespace kata_gof_pattern_command_mars_rover
{
    public class RoverController
    {

        public string ProcessInput(string input)
        {
            var position = Position.Parse(input);

            var commandParser = new CommandParser();

            var inputs = input.Split(' ');
            foreach (var commandChar in inputs[5])
            {
                var command = commandParser.Parse(commandChar);
                command.Position = position;
                command.Execute();
            }

            return position.ToString();
        }
    }
}