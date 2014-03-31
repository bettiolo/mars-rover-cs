using System.Drawing;

namespace MarsRover
{
	public class Rover
	{
		private readonly Planet _planet;

		public Rover(Planet planet)
		{
			_planet = planet;
		}

		public Point Position { get; private set; }
		public Orientation Orientation { get; private set; }

		public void Land(int x, int y, Orientation orientation)
		{
			Position = new Point(x, y);
			Orientation = orientation;
		}
	}
}