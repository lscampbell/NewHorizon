using System;
using Xunit;

namespace PlutoRover.Tests
{
    public class PlutoRoverMoveRequestShould
    {
        [Fact]
        public void WhenRequestedToMoveForwardShould()
        {
            var rover = new Rover();
            rover.Move("F");
            Assert.Equal("0,1,N", rover.GetLocation());
        }

        [Fact]
        public void WhenAskedToMoveBackwardShould()
        {
            var rover = new Rover(0,1);
            rover.Move("B");
            Assert.Equal("0,0,N", rover.GetLocation());
        }

        [Fact]
        public void WhenAskedToMoveLeftShould()
        {
            var rover = new Rover();
            rover.Move("L");
            Assert.Equal("0,0,W", rover.GetLocation());
        }
        
        [Fact]
        public void WhenAskedToMoveRightShould()
        {
            var rover = new Rover();
            rover.Move("R");
            Assert.Equal("0,0,E", rover.GetLocation());
        }

    }
}
