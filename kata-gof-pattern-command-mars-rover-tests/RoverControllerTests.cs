using kata_gof_pattern_command_mars_rover;
using Xunit;

namespace kata_gof_pattern_command_mars_rover_tests
{
    public class RoverControllerTests
    {
        [Theory]
        [InlineData("5 5 0 0 N M", "0 1 N")]
        [InlineData("5 5 0 1 N M", "0 2 N")]
        [InlineData("5 5 1 1 N M", "1 2 N")]
        [InlineData("5 5 1 1 E M", "2 1 E")]
        [InlineData("5 5 1 1 S M", "1 0 S")]
        [InlineData("5 5 1 1 W M", "0 1 W")]
        public void ProcessInput_ParseOriginAndMove_ReturnsCorrectPosition(string input, string expected)
        {
            var rover = new RoverController();
            var actual = rover.ProcessInput(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("5 5 0 0 N R", "0 0 E")]
        [InlineData("5 5 0 0 E R", "0 0 S")]
        [InlineData("5 5 0 0 S R", "0 0 W")]
        [InlineData("5 5 0 0 W R", "0 0 N")]
        public void ProcessInput_ParseOriginAndTurnRight_ReturnsCorrectPosition(string input, string expected)
        {
            var rover = new RoverController();
            var actual = rover.ProcessInput(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("5 5 0 0 N L", "0 0 W")]
        [InlineData("5 5 0 0 W L", "0 0 S")]
        [InlineData("5 5 0 0 S L", "0 0 E")]
        [InlineData("5 5 0 0 E L", "0 0 N")]
        public void ProcessInput_ParseOriginAndTurnLeft_ReturnsCorrectPosition(string input, string expected)
        {
            var rover = new RoverController();
            var actual = rover.ProcessInput(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("5 5 0 0 N ML", "0 1 W")]
        [InlineData("5 5 0 0 N MRM", "1 1 E")]
        [InlineData("5 5 3 3 N MRMLLMLMRR", "3 3 N")]
        public void ProcessInput_CommandSequence_ReturnsCorrectPosition(string input, string expected)
        {
            var rover = new RoverController();
            var actual = rover.ProcessInput(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("", "Invalid position: not enough fields in input string")]
        [InlineData("5 5 O 1 M", "Invalid value format 'O'")]
        [InlineData("5 5 1 N M", "Invalid value format 'N'")]
        [InlineData("5 5 1 1 X M", "Invalid value format 'X'")]
        [InlineData("5 5 0 0 N 1", "Invalid command '1'")]
        [InlineData("5 5 0 0 N ML1", "Invalid command '1'")]
        public void ProcessInput_InvalidPosition_ReportsError(string input, string expected)
        {
            var rover = new RoverController();
            var actual = rover.ProcessInput(input);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("5 5 4 4 N M", "4 0 N")]
        [InlineData("5 5 0 0 S M", "0 4 S")]
        [InlineData("5 5 4 0 E M", "0 0 E")]
        [InlineData("5 5 0 0 W M", "4 0 W")]
        [InlineData("6 5 0 0 W M", "5 0 W")]
        [InlineData("5 6 0 0 S M", "0 5 S")]
        public void ProcessInput_RoverLeavesGrid_ReturnsWrappedPosition(string input, string expected)
        {
            var rover = new RoverController();
            var actual = rover.ProcessInput(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("X 5 1 1 N M", "Invalid value format 'X'")]
        [InlineData("5 Y 1 1 N M", "Invalid value format 'Y'")]
        public void ProcessInput_InvalidPlateauSize_ReportsError(string input, string expected)
        {
            var rover = new RoverController();
            var actual = rover.ProcessInput(input);
            Assert.Equal(actual, expected);
        }
    }
}