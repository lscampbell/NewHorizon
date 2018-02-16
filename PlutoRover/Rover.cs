using System;

namespace PlutoRover
{
    public class Rover
    {
        Location _position;
        public Rover(int x = 0, int y = 0, string heading = "N")
        {
            _position = new Location { Heading = heading, X = x, Y = y };
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
                case "B": _position = Back(_position);
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
                case "N": return new Location{
                        Heading = position.Heading,
                        X = position.X,
                        Y = position.Y += 1
                    };
                case "E": return new Location{
                        Heading = position.Heading,
                        X = position.X += 1,
                        Y = position.Y
                    };
                case "S": return new Location{
                        Heading = position.Heading,
                        X = position.X,
                        Y = position.Y -= 1
                    };
                case "W": return new Location{
                        Heading = position.Heading,
                        X = position.X -= 1,
                        Y = position.Y
                    };
            }
            return position;
        }

        Location Back(Location position)
        {
            switch(position.Heading)
            {
                case "N": return new Location{
                            Heading = position.Heading,
                            X = position.X,
                            Y = position.Y -= 1
                        };
                case "E": return new Location{
                            Heading = position.Heading,
                            X = position.X -= 1,
                            Y = position.Y
                        };
                case "S": return new Location{
                            Heading = position.Heading,
                            X = position.X,
                            Y = position.Y += 1
                        };
                case "W": return new Location{
                            Heading = position.Heading,
                            X = position.X += 1,
                            Y = position.Y
                        };
            }
            return position;
        } 
    }
}
