
namespace MarsRover
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }
        public int DirectionAngle { get; set; }
        public Position(int x=0, int y=0, Directions d=Directions.N)
        {
            X = x;
            Y = y;
            Direction = d;
            DirectionAngle = (int)d * 90;
        }
    }
}
