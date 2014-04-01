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
			Rotate(90);
		}

		public void RotateLeft()
		{
			Rotate(-90);
		}

		private void Rotate(int degrees)
		{
			var newOrientation = ((int) Orientation) + degrees;
			if (newOrientation >= 360)
			{
				newOrientation -= 360;
			}
			if (newOrientation < 0)
			{
				newOrientation += 360;
			}
			Orientation = (Orientation) newOrientation;
		}
	}
}