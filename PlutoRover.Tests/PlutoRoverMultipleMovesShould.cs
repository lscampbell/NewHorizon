using System;
using Xunit;

namespace PlutoRover.Tests
{
    public class PlutoRoverMultipleMovesShould

    {
        [Fact]
        public void WhenAskedToMoveShould()
        {
            var Rover = new Rover();
            var moves = new string[] {"F","F","R","F","F"};
            Rover.Move(moves);
            Assert.Equal("2,2,E", Rover.GetLocation());
        }
    }
}
