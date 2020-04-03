namespace kata_gof_pattern_command_mars_rover
{
    public abstract class Command
    {
        public Position Position { get; set; }

        public abstract void Execute();
    }
}