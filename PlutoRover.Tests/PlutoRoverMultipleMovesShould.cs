using System;
using Xunit;

namespace PlutoRover.Tests
{
    public class PlutoRoverMultipleMovesShould

    {
        [Fact]
        public void WhenAskedToMoveShould()
        {
            var rover = new Rover();
            var moves = new string[] {"F","F","R","F","F"};
            rover.Move(moves);
            Assert.Equal("2,2,E", rover.GetLocation());
        }
    }
}
