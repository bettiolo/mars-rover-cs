using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace MarsRover
{
	public class Rover
	{
		public int X { get; private set; }
		public int Y { get; private set; }
		public Orientation Orientation { get; private set; }

		public void Land(int x, int y, Orientation orientation)
		{
			X = x;
			Y = y;
			Orientation = orientation;
		}

		public void Forward()
		{
			Y += 1;
		}
	}
}