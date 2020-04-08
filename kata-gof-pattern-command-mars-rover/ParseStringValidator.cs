using System;

namespace kata_gof_pattern_command_mars_rover
{
    public static class ParseStringValidator
    {
        public delegate bool TryParseFunc<TValue>(string inputField, out TValue value);

        public static void ValidateParsing<TValue>(string inputField, TryParseFunc<TValue> tryParseFunc)
        {
            if (!tryParseFunc(inputField, out _))
                throw new InputParseException(String.Format(InputParseException.InvalidValueFormatMessage,
                    inputField));
        }
    }
}