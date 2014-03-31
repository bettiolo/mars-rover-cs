using System.Drawing;

namespace MarsRover
{
	public class Rover
	{
		public Point Position { get; private set; }
		public Orientation Orientation { get; private set; }

		public void Land(int x, int y, Orientation orientation)
		{
			Position = new Point(x, y);
			Orientation = orientation;
		}
	}
}