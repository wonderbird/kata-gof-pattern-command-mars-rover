using System;

namespace kata_gof_pattern_command_mars_rover
{
    public class RoverController
    {
        private readonly Position _position = new Position();

        public string ProcessInput(string input)
        {
            _position.ParsePosition(input);

            var inputs = input.Split(' ');
            foreach (var commandChar in inputs[5])
            {
                switch (commandChar)
                {
                    case 'M':
                        Move();
                        break;

                    case 'R':
                        TurnRight();
                        break;

                    case 'L':
                        TurnLeft();
                        break;
                }
            }
            return _position.ToString();
        }

        private void TurnLeft()
        {
            if (_position.Orientation != Orientation.North)
                _position.Orientation -= 1;
            else
                _position.Orientation = Orientation.West;
        }

        private void TurnRight()
        {
            if (_position.Orientation != Orientation.West)
                _position.Orientation += 1;
            else
                _position.Orientation = Orientation.North;
        }

        private void Move()
        {
            switch (_position.Orientation)
            {
                case Orientation.North:
                    _position.Y += 1;
                    break;

                case Orientation.East:
                    _position.X += 1;
                    break;

                case Orientation.South:
                    _position.Y -= 1;
                    break;

                case Orientation.West:
                    _position.X -= 1;
                    break;
            }
        }
    }
}