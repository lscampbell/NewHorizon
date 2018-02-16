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

        public void Move(string direction)
        {
            switch(direction)
            {
                case "F": _position = Forward(_position);
                    break;
            }
        }

        public string GetLocation()
        {
            return $"{_position.X},{_position.Y},{_position.Heading}";
        }

        Location Forward(Location position)
        {
            switch(position.Heading)
            {
                case "N":
                    return new Location{
                        Heading = position.Heading,
                        X = position.X,
                        Y = position.Y += 1
                    };
            }
            return position;
        } 
    }
}
