namespace kata_gof_pattern_command_mars_rover
{
    public class TurnLeftCommand : Command, ICommandFactory
    {
        public char CommandName => 'L';

        public Command Create()
        {
            var command = new TurnLeftCommand();
            return command;
        }

        public override void Execute()
        {
            if (Position.Orientation != Orientation.North)
                Position.Orientation -= 1;
            else
                Position.Orientation = Orientation.West;
        }
    }
}