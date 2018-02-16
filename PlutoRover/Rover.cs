using System;

namespace PlutoRover
{
    public class Rover
    {
        Location _position;
        public Rover()
        {
            _position = new Location { Heading = "N", X = 0, Y = 0 };
        }
        public void Move(string[] moves)
        {
        }
        public void Move(string move)
        {
        }
        public string GetLocation()
        {
            return $"{_position.Heading},{_position.X},{_position.Y}";
        }
    }
}
