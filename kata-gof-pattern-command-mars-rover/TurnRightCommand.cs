namespace kata_gof_pattern_command_mars_rover
{
    public class TurnRightCommand : Command, ICommandFactory
    {
        public char CommandName => 'R';

        public Command Create()
        {
            var command = new TurnRightCommand();
            return command;
        }

        public override void Execute()
        {
            if (Position.Orientation != Orientation.West)
                Position.Orientation += 1;
            else
                Position.Orientation = Orientation.North;
        }
    }
}