using NUnit.Framework;
using FluentAssertions;

namespace MarsRover.Tests.Unit
{
	[TestFixture]
	public class RoverTests
	{

		private Rover _rover;

		[SetUp]
		public void Setup()
		{
			_rover = new Rover();	
		}

		[Test]
		public void RoverLandsOnPlanetWithDefaultPosition()
		{
			_rover.Land(0, 0, Orientation.N);

			_rover.X.Should().Be(0);
			_rover.Y.Should().Be(0);
		}

		[Test]
		public void RoverLandsOnSpecificPosition()
		{	
			var landingX = 1;
			var landingY = 1;
		
			_rover.Land(landingX, landingY, Orientation.N);

			_rover.X.Should().Be(1);
			_rover.Y.Should().Be(1);
		}

		[Test]
		public void RoverLandsWithNorthOrientation()
		{
			_rover.Land(0, 0, Orientation.N);

			_rover.Orientation.Should().Be(Orientation.N);
		}

		[TestCase(Orientation.E)]
		[TestCase(Orientation.S)]
		[TestCase(Orientation.W)]
		public void RoverLandsWithDifferentOrientations(Orientation orientation)
		{
			_rover.Land(0, 0, orientation);

			_rover.Orientation.Should().Be(orientation);
		}

		[Test]
		public void RoverMovesForwardByOneCell()
		{
			_rover.Land(0, 0, Orientation.N);

			_rover.Forward();

			_rover.Y.Should().Be(1);
		}
	}
}
