using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class RoverNavigator
    {
        public Position position { get; set; }

        private void Rotate90DegreesToLeft()
        {
            switch (position.Direction)
            {
                case Directions.N:
                    position.Direction = Directions.W;
                    break;
                case Directions.S:
                    position.Direction = Directions.E;
                    break;
                case Directions.E:
                    position.Direction = Directions.N;
                    break;
                case Directions.W:
                    position.Direction = Directions.S;
                    break;
                default:
                    break;
            }
        }

        private void Rotate90DegreesToRight()
        {
            switch (position.Direction)
            {
                case Directions.N:
                    position.Direction = Directions.E;
                    break;
                case Directions.S:
                    position.Direction = Directions.W;
                    break;
                case Directions.E:
                    position.Direction = Directions.S;
                    break;
                case Directions.W:
                    position.Direction = Directions.N;
                    break;
                default:
                    break;
            }
        }

        private void MoveOneUnitToForward()
        {
            switch (position.Direction)
            {
                case Directions.N:
                    position.Y += 1;
                    break;
                case Directions.S:
                    position.Y -= 1;
                    break;
                case Directions.E:
                    position.X += 1;
                    break;
                case Directions.W:
                    position.X -= 1;
                    break;
                default:
                    break;
            }
        }

        public void MoveWithInstructions(List<int> maxPoints, string instructions)
        {
            foreach (var move in instructions)
            {
                switch (move)
                {
                    case 'M':
                        MoveOneUnitToForward();
                        break;
                    case 'L':
                        Rotate90DegreesToLeft();
                        break;
                    case 'R':
                        Rotate90DegreesToRight();
                        break;
                    default:
                        Console.WriteLine($"Invalid instraction '{move}', please use 'R', 'L' or 'M'");
                        break;
                }

                if (position.X < 0 || position.X > maxPoints[0] || position.Y < 0 || position.Y > maxPoints[1])
                {
                    throw new Exception($"Warning! Danger of losing signal from rover! Position should be between bounderies (0 , 0) and ({maxPoints[0]} , {maxPoints[1]})");
                }
            }
        }
    }
}
