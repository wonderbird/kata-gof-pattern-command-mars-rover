namespace kata_gof_pattern_command_mars_rover
{
    public class Plateau
    {
        public static Position WrapPosition(Position position)
        {
            var AreaSizeX = 5;
            var AreaSizeY = 5;

            position.X = WrapCoordinate(position.X, AreaSizeX);
            position.Y = WrapCoordinate(position.Y, AreaSizeY);

            return position;
        }

        private static int WrapCoordinate(int unwrappedValue, int areaSize)
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