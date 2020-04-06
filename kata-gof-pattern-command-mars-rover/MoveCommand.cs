namespace kata_gof_pattern_command_mars_rover
{
    public class MoveCommand : Command, ICommandFactory
    {
        public char CommandName => 'M';

        public Command Create()
        {
            var command = new MoveCommand();
            return command;
        }

        public override void Execute()
        {
            switch (Position.Orientation)
            {
                case Orientation.North:
                    Position.Y += 1;
                    break;

                case Orientation.East:
                    Position.X += 1;
                    break;

                case Orientation.South:
                    Position.Y -= 1;
                    break;

                case Orientation.West:
                    Position.X -= 1;
                    break;
            }
        }
    }
}