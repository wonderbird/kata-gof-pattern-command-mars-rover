using System;

namespace kata_gof_pattern_command_mars_rover
{
    public class InputParseException : Exception
    {
        public const string InvalidPositionMessage = "Invalid position: not enough fields in input string";

        public const string InvalidCommandMessage = "Invalid command '{0}'";

        public const string InvalidValueFormatMessage = "Invalid value format '{0}'";

        public InputParseException(string message)
            : base(message)
        {
        }
    }
}