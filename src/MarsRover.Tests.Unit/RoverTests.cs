using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace MarsRover.Tests.Unit
{
	[TestFixture]
	public class RoverTests
	{

		[Test]
		public void RoverLandsOnPlanetWithDefaultPosition()
		{
			var planet = new Planet();
			var rover = new Rover(planet);

			rover.Land();

			rover.Position.X.Should().Be(0);
			rover.Position.Y.Should().Be(0);
		}
	}

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

	public class Planet
	{

	}

}
