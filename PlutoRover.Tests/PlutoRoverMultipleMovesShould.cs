using System;
using Xunit;

namespace PlutoRover.Tests
{
    public class PlutoRoverMultipleMovesShould

    {
        [Fact]
        public void WhenRequestedToMoveForwardShould()
        {
            var rover = new Rover();

            rover.Move("F");

            Assert.Equal("0,1,N", rover.GetLocation());
        }
    }
}
