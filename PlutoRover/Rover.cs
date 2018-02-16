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
            foreach(var direction in moves)
                Execute(direction);
        }

        public void Move(string direction)
        {
            Execute(direction);
        }

        void Execute(string direction)
        {
            switch (direction)
            {
                case "F": _position = Forward(_position);
                    break;
                case "B": _position = Back(_position);
                    break;
                case "L": _position.Heading = Left(_position.Heading);
                    break;
                case "R": _position.Heading = Right(_position.Heading);
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
        
        string Left(string heading)
        {
            switch(heading)
            {
                case "N":
                        return "W";
                case "E":
                        return "N";
                case "S":
                        return  "E";
                case "W":
                        return  "S";
            }
            return heading;
        }
        
        string Right(string heading)
        {
            switch(heading)
            {
                case "N":
                        return "E";
                case "E":
                        return "S";
                case "S":
                        return "W";
                case "W":
                        return "N";
            }
            return heading;
        } 
    }
}
