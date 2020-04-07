using System;

namespace kata_gof_pattern_command_mars_rover
{
    public class Position
    {
        public Orientation Orientation { set; get; }

        public int X { set; get; }

        public int Y { set; get; }

        public override string ToString()
        {
            return $"{X} {Y} {Orientation.ToChar()}";
        }
    }
}