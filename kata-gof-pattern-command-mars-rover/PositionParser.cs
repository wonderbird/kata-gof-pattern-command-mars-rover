namespace kata_gof_pattern_command_mars_rover
{
    public static class PositionParser
    {
        private const int NumberOfFields = 5;
        private const int IndexOfX = 2;
        private const int IndexOfY = 3;
        private const int IndexOfOrientation = 4;

        public static Position Parse(string input)
        {
            var inputFields = input.Split(' ');

            ValidateInput(inputFields);

            var position = new Position();

            position.X = int.Parse(inputFields[IndexOfX]);
            position.Y = int.Parse(inputFields[IndexOfY]);

            var orientationChar = inputFields[IndexOfOrientation];
            position.Orientation = OrientationExtensions.Parse(orientationChar);

            return position;
        }

        private static void ValidateInput(string[] inputFields)
        {
            // TODO: Move Field count validation out to higher level
            ValidateNumberOfFields(inputFields);

            ParseStringValidator.ValidateParsing<int>(inputFields[IndexOfX], int.TryParse);
            ParseStringValidator.ValidateParsing<int>(inputFields[IndexOfY], int.TryParse);
            ParseStringValidator.ValidateParsing<Orientation>(inputFields[IndexOfOrientation], OrientationExtensions.TryParse);
        }

        private static void ValidateNumberOfFields(string[] inputFields)
        {
            if (inputFields.Length < NumberOfFields)
                throw new InputParseException(InputParseException.InvalidPositionMessage);
        }
    }
}