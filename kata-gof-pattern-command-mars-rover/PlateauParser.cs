namespace kata_gof_pattern_command_mars_rover
{
    public static class PlateauParser
    {
        private const int IndexOfAreaSizeX = 0;
        private const int IndexOfAreaSizeY = 1;

        public static Plateau Parse(string[] inputFields)
        {
            ValidateInput(inputFields);

            var plateau = new Plateau();
            plateau.AreaSizeX = int.Parse(inputFields[IndexOfAreaSizeX]);
            plateau.AreaSizeY = int.Parse(inputFields[IndexOfAreaSizeY]);

            return plateau;
        }

        private static void ValidateInput(string[] inputFields)
        {
            ParseStringValidator.ValidateParsing<int>(inputFields[IndexOfAreaSizeX], int.TryParse);
            ParseStringValidator.ValidateParsing<int>(inputFields[IndexOfAreaSizeY], int.TryParse);
        }
    }
}