namespace kata_gof_pattern_command_mars_rover
{
    public interface ICommandFactory
    {
        char CommandName { get; }

        Command Create();
    }
}