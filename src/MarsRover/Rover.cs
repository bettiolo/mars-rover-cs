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

		public void MoveForward()
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

		public void MoveBackward()
		{
			switch (Orientation)
			{
				case Orientation.N:
					Y -= 1;
					break;
				case Orientation.E:
					X -= 1;
					break;
				case Orientation.S:
					Y += 1;
					break;
				case Orientation.W:
					X += 1;
					break;
			}
		}

		public void RotateRight()
		{
			switch (Orientation)
			{
				case Orientation.N:
					Orientation = Orientation.E;
					break;
				case Orientation.E:
					Orientation = Orientation.S;
					break;
				case Orientation.S:
					Orientation = Orientation.W;
					break;
				case Orientation.W:
					Orientation = Orientation.N;
					break;
			}
		}

		public void RotateLeft()
		{
			switch (Orientation)
			{
				case Orientation.N:
					Orientation = Orientation.W;
					break;
				case Orientation.E:
 					Orientation = Orientation.N;
					break;
				case Orientation.S:
					Orientation = Orientation.E;
					break;
				case Orientation.W:
					Orientation = Orientation.S;
					break;
			}
		}

	}
}