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
            var Rover = new Rover(0,1);
            Rover.Move("B");
            Assert.Equal("0,0,N", Rover.GetLocation());
        }

        [Fact]
        public void WhenAskedToMoveLeftShould()
        {
            var Rover = new Rover();
            Rover.Move("L");
            Assert.Equal("0,0,W", Rover.GetLocation());
        }
        
        [Fact]
        public void WhenAskedToMoveRightShould()
        {
            var Rover = new Rover();
            Rover.Move("R");
            Assert.Equal("0,0,E", Rover.GetLocation());
        }

    }
}
