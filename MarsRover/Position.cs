
namespace MarsRover
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }
        public Position()
        {
            X = 0;
            Y = 0;
            Direction = Directions.N;
        }
    }
}
