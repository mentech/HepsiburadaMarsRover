using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxPoints = new List<int>();
            string[] startPositions = { };
            RoverNavigator roverNavigator = new RoverNavigator();

            try
            {
                Console.Write("The upper-right coordinates of the plateau: ");
                maxPoints = Console.ReadLine().Trim().Split(' ').Select(c => int.Parse(c)).ToList();
                Console.Write("The rover's position: ");
                startPositions = Console.ReadLine().Trim().Split(' ');

                if (startPositions.Count() != 3)
                {
                    throw new Exception("Start position should have 3 unit. Example: 0 0 N");
                }

                roverNavigator.position = new Position(Convert.ToInt32(startPositions[0]), Convert.ToInt32(startPositions[1]), (Directions)Enum.Parse(typeof(Directions), startPositions[2].ToUpper()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(null);
            }

            Console.Write("The rover's movement instructions: ");
            var instructions = Console.ReadLine().Trim().ToUpper();

            try
            {
                roverNavigator.MoveWithInstructions(maxPoints, instructions);
                Console.WriteLine($"{roverNavigator.position.X} {roverNavigator.position.Y} {roverNavigator.position.Direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(null);
            }

            Console.ReadLine();
        }
    }
}
