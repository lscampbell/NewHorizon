using System;
using Xunit;

namespace PlutoRover.test
{
    public class PlutoRoverEdgeToEdgeShouldResolve
    {
        [Fact]
        public void WhenAskedToMoveOffMapNorthShould()
        {
            var Rover = new Rover(0, 9, "N", 9, 9);
            var moves = new string[] {"F"};
            
            Rover.Move(moves);
            
            Assert.Equal("0,0,N", Rover.GetLocation());
        }
    }
}