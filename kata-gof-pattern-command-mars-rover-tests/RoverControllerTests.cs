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
        public void ProcessInput_ParseOriginAndMove_ReturnsCorrectPosition(string input, string expected)
        {
            var rover = new RoverController();
            string actual = rover.ProcessInput(input);
            Assert.Equal(expected, actual);
        }
    }
}
