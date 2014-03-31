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
			var rover = new Rover();

			rover.Land(0, 0, Orientation.N);

			rover.Position.X.Should().Be(0);
			rover.Position.Y.Should().Be(0);
		}

		[Test]
		public void RoverLandsOnSpecificPosition()
		{
			var rover = new Rover();
			var landingX = 1;
			var landingY = 1;
		
			rover.Land(landingX, landingY, Orientation.N);

			rover.Position.X.Should().Be(1);
			rover.Position.Y.Should().Be(1);
		}

		[Test]
		public void RoverLandsWithNorthOrientation()
		{
			var rover = new Rover();

			rover.Land(0, 0, Orientation.N);

			rover.Orientation.Should().Be(Orientation.N);
		}

		[TestCase(Orientation.E)]
		[TestCase(Orientation.S)]
		[TestCase(Orientation.W)]
		public void RoverLandsWithDifferentOrientations(Orientation orientation)
		{
			var rover = new Rover();

			rover.Land(0, 0, orientation);

			rover.Orientation.Should().Be(orientation);
		}
	}
}
