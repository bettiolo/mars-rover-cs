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

		public Point Position { get; set; }

		public void Land()
		{
			
		}

	}

}