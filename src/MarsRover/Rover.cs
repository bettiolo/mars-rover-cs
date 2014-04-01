﻿namespace MarsRover
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
			switch (Orientation)
			{
				case Orientation.N:
					Y += 1;
					break;
				case Orientation.E:
					X += 1;
					break;
				case Orientation.S:
					Y -= 1;
					break;
				case Orientation.W:
					X -= 1;
					break;
			}
		}
	}
}