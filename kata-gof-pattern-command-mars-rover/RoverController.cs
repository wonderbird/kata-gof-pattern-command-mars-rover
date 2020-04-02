using System;
using System.Collections.Generic;

namespace kata_gof_pattern_command_mars_rover
{
    public class RoverController
    {
        public string ProcessInput(string input)
        {
            throw new Exception("Next step: Refactor this method");
            var inputFields = input.Split(' ');
            var x = int.Parse(inputFields[2]);
            var y = int.Parse(inputFields[3]);

            var characterToOrientation = new Dictionary<string, Orientation>
            {
                {"N", Orientation.North},
                {"E", Orientation.East},
                {"S", Orientation.South},
                {"W", Orientation.West}
            };
            var orientationChar = inputFields[4];
            var orientation = characterToOrientation[orientationChar];

            var newX = x;
            var newY = y;
            if (orientation == Orientation.North)
                newY += 1;
            else
                newX += 1;

            return $"{newX} {newY} {orientationChar}";
        }
    }
}