namespace kata_gof_pattern_command_mars_rover
{
    public class Position
    {
        public Orientation Orientation { set; get; }

        public int X { set; get; }

        public int Y { set; get; }

        public void ParsePosition(string input)
        {
            var inputFields = input.Split(' ');
            X = int.Parse(inputFields[2]);
            Y = int.Parse(inputFields[3]);

            var orientationChar = inputFields[4];
            Orientation = OrientationExtensions.Parse(orientationChar);
        }

        public override string ToString()
        {
            return $"{X} {Y} {Orientation.ToChar()}";
        }
    }
}