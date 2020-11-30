using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MarsRoverUnitTest
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestMethod]
        public void Test_12N_LMLMLMLMM()
        {
            var maxPoints = new List<int>() { 5, 5 };

            RoverNavigator roverNavigator = new RoverNavigator();

            roverNavigator.position = new Position
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };

            var instructions = "LMLMLMLMM";

            roverNavigator.MoveWithInstructions(maxPoints, instructions);

            var actualOutput = $"{roverNavigator.position.X} {roverNavigator.position.Y} {roverNavigator.position.Direction.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Test_33E_MRRMMRMRRM()
        {
            var maxPoints = new List<int>() { 5, 5 };

            RoverNavigator roverNavigator = new RoverNavigator();
            roverNavigator.position = new Position
            {
                X = 3,
                Y = 3,
                Direction = Directions.E
            };

            var instructions = "MRRMMRMRRM";

            roverNavigator.MoveWithInstructions(maxPoints, instructions);

            var actualOutput = $"{roverNavigator.position.X} {roverNavigator.position.Y} {roverNavigator.position.Direction.ToString()}";
            var expectedOutput = "2 3 S";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
