using System.Collections.Generic;
using System.Linq;

namespace kata_gof_pattern_command_mars_rover
{
    public static class OrientationExtensions
    {
        private static readonly Dictionary<string, Orientation> CharacterToOrientation = new Dictionary<string, Orientation>
        {
            {"N", Orientation.North},
            {"E", Orientation.East},
            {"S", Orientation.South},
            {"W", Orientation.West}
        };

        public static string ToChar(this Orientation orientation)
        {
            var orientationChar = CharacterToOrientation
                .First((characterOrientationPair) => characterOrientationPair.Value == orientation).Key;

            return orientationChar;
        }

        public static Orientation Parse(string orientationChar)
        {
            return CharacterToOrientation[orientationChar];
        }
    }
}