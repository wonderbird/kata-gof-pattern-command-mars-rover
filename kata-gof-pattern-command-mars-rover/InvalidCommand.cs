namespace kata_gof_pattern_command_mars_rover
{
    internal class InvalidCommand : Command, ICommandFactory
    {
        public char CommandName => 'X';

        public Command Create()
        {
            return new InvalidCommand();
        }

        public override void Execute()
        {
        }
    }
}