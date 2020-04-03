namespace kata_gof_pattern_command_mars_rover
{
    public class RoverController
    {
        private readonly Position _position = new Position();

        public string ProcessInput(string input)
        {
            _position.ParsePosition(input);

            var commandFactory = new CommandFactory(_position);

            var inputs = input.Split(' ');
            foreach (var commandChar in inputs[5])
            {
                var command = commandFactory.Create(commandChar);
                command.Execute();
            }

            return _position.ToString();
        }
    }
}