namespace kata_gof_pattern_command_mars_rover
{
    public class Position
    {
        public Orientation Orientation { set; get; }

        public int X { set; get; }

        public int Y { set; get; }

        public static Position Parse(string input)
        {
            var position = new Position();

            var inputFields = input.Split(' ');
            position.X = int.Parse(inputFields[2]);
            position.Y = int.Parse(inputFields[3]);

            var orientationChar = inputFields[4];
            position.Orientation = OrientationExtensions.Parse(orientationChar);

            return position;
        }

        public override string ToString()
        {
            return $"{X} {Y} {Orientation.ToChar()}";
        }
    }
}