using System;

namespace kata_gof_pattern_command_mars_rover
{
    public class RoverController
    {
        private readonly Position _position = new Position();

        public string ProcessInput(string input)
        {
            _position.ParsePosition(input);
            if (_position.Orientation == Orientation.North)
                _position.Y += 1;
            else
                _position.X += 1;

            return _position.ToString();
        }
    }
}