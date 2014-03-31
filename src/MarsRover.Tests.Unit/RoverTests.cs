using System;
using System.CodeDom;
using System.Collections.Generic;
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

			rover.Land(0, 0);

			rover.Position.X.Should().Be(0);
			rover.Position.Y.Should().Be(0);
		}

		[Test]
		public void RoverLandsOnSpecificPosition()
		{
			var planet = new Planet();
			var rover = new Rover(planet);
			var landingX = 1;
			var landingY = 1;
		
			rover.Land(landingX, landingY);

			rover.Position.X.Should().Be(1);
			rover.Position.Y.Should().Be(1);
		}
	}
}
