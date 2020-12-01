using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class RoverNavigator
    {
        public Position position { get; set; }

        private void MoveOneUnitToForward()
        {
            position.DirectionAngle = position.DirectionAngle % 360;

            if (position.DirectionAngle<0)
            {
                position.DirectionAngle += 360;
            }

            switch (position.DirectionAngle)
            {
                case 0:
                    position.Y += 1;
                    break;
                case 90:
                    position.X += 1;
                    break;
                case 180:
                    position.Y -= 1;
                    break;
                case 270:
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
                        position.DirectionAngle -= 90;
                        break;
                    case 'R':
                        position.DirectionAngle += 90;
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
