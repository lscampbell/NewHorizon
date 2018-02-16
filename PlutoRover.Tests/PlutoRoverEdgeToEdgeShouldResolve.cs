using System;
using Xunit;

namespace PlutoRover.test
{
    public class PlutoRoverEdgeToEdgeShouldResolve
    {
        [Fact]
        public void WhenAskedToMoveOffMapNorthShould()
        {
            var rover = new Rover(0, 9, "N", 9, 9);
            var moves = new string[] {"F"};
            
            rover.Move(moves);
            
            Assert.Equal("0,0,N", rover.GetLocation());
        }

        [Fact]
        public void WhenAskedToMoveOffMapSouthShould()
        {
            var rover = new Rover(0, 0, "N", 9, 9);
            var moves = new string[] {"B"};
            
            rover.Move(moves);
            
            Assert.Equal("0,9,N", rover.GetLocation());
        }
        
        [Fact]
        public void WhenAskedToMoveOffMapAFewTimesShould()
        {
            var rover = new Rover(0, 9, "N", 9, 9);
            var moves = new string[] {"F","L","F","L","F","L","F","L"};

            rover.Move(moves);
            
            Assert.Equal("0,9,N", rover.GetLocation());
        }

        [Fact]
        public void WhenAskedToMoveAroundMapAFewTimesShould()
        {
            var rover = new Rover(0, 9, "N", 9, 9);
            var moves = new string[] {"F","L","L","L","F","R","F"};

            rover.Move(moves);

            Assert.Equal("1,9,S", rover.GetLocation());
        }
        
        [Fact]
        public void WhenAskedToMoveAroundMapBackwardsShould()
        {
            var rover = new Rover(0, 0, "N", 9, 9);
            var moves = new string[] {"B","R","B","R","B","R","B","R"};

            rover.Move(moves);
            
            Assert.Equal("0,0,N", rover.GetLocation());
        }
    }
}