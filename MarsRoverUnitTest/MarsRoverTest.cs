using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MarsRoverUnitTest
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestMethod]
        public void Move_12N_LMLMLMLMM_13N()
        {
            var maxPoints = new List<int>() { 5, 5 };

            RoverNavigator roverNavigator = new RoverNavigator();

            roverNavigator.position = new Position(1,2,Directions.N);

            var instructions = "LMLMLMLMM";

            roverNavigator.MoveWithInstructions(maxPoints, instructions);

            var actualOutput = $"{roverNavigator.position.X} {roverNavigator.position.Y} {roverNavigator.position.Direction.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Move_33E_MRRMMRMRRM_51E()
        {
            var maxPoints = new List<int>() { 5, 5 };

            RoverNavigator roverNavigator = new RoverNavigator();
            roverNavigator.position = new Position(3, 3, Directions.E);
            
            var instructions = "MMRMMRMRRM";

            roverNavigator.MoveWithInstructions(maxPoints, instructions);

            var actualOutput = $"{roverNavigator.position.X} {roverNavigator.position.Y} {roverNavigator.position.Direction.ToString()}";
            var expectedOutput = "5 1 E";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
