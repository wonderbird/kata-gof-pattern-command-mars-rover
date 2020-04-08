namespace kata_gof_pattern_command_mars_rover
{
    public class Plateau
    {
        public int AreaSizeX { get; set; }
        public int AreaSizeY { get; set; }

        public Position WrapPosition(Position position)
        {
            position.X = WrapCoordinate(position.X, AreaSizeX);
            position.Y = WrapCoordinate(position.Y, AreaSizeY);

            return position;
        }

        private int WrapCoordinate(int unwrappedValue, int areaSize)
        {
            var wrappedValue = unwrappedValue;

            if (unwrappedValue >= areaSize)
            {
                wrappedValue -= areaSize;
            }

            if (unwrappedValue < 0)
            {
                wrappedValue = areaSize + unwrappedValue;
            }

            return wrappedValue;
        }
    }
}