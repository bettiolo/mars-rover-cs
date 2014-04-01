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
		public void LandsOnPlanetWithDefaultPosition()
		{
			_rover.Land(0, 0, Orientation.N);

			_rover.X.Should().Be(0);
			_rover.Y.Should().Be(0);
		}

		[Test]
		public void LandsOnSpecificPosition()
		{	
			var landingX = 1;
			var landingY = 1;
		
			_rover.Land(landingX, landingY, Orientation.N);

			_rover.X.Should().Be(1);
			_rover.Y.Should().Be(1);
		}

		[Test]
		public void LandsWithNorthOrientation()
		{
			_rover.Land(0, 0, Orientation.N);

			_rover.Orientation.Should().Be(Orientation.N);
		}

		[TestCase(Orientation.E)]
		[TestCase(Orientation.S)]
		[TestCase(Orientation.W)]
		public void LandsWithDifferentOrientations(Orientation orientation)
		{
			_rover.Land(0, 0, orientation);

			_rover.Orientation.Should().Be(orientation);
		}

		[Test]
		public void MovesForwardNorthByOneCellIfOrientationIsNorth()
		{
			_rover.Land(0, 0, Orientation.N);

			_rover.Forward();

			_rover.X.Should().Be(0);
			_rover.Y.Should().Be(1);
		}

		[Test]
		public void MovesForwardEastByOneCellIfOrientationIsEast()
		{
			_rover.Land(1, 1, Orientation.E);

			_rover.Forward();

			_rover.X.Should().Be(2);
			_rover.Y.Should().Be(1);
		}

		[Test]
		public void MovesForwardSouthByOneCellIfOrientationIsSouth()
		{
			_rover.Land(2, 2, Orientation.S);

			_rover.Forward();

			_rover.X.Should().Be(2);
			_rover.Y.Should().Be(1);
		}

		[Test]
		public void MovesForwardWestByOneCellIfOrientationIsWest()
		{
			_rover.Land(3, 3, Orientation.W);

			_rover.Forward();

			_rover.X.Should().Be(2);
			_rover.Y.Should().Be(3);
		}

		[Test]
		public void MovesBackwardsSouthByOneCellIfOrientationIsNorth()
		{
			_rover.Land(1,1, Orientation.N);

			_rover.Backwards();

			_rover.X.Should().Be(1);
			_rover.Y.Should().Be(0);
		}

		[Test]
		public void MovesBackwardsWestByOneCellIfOrientationIsEast()
		{
			_rover.Land(1, 1, Orientation.E);

			_rover.Backwards();

			_rover.X.Should().Be(0);
			_rover.Y.Should().Be(1);
		}

		[Test]
		public void MovesBackwardsNorthByOneCellIfOrientationIsSouth()
		{
			_rover.Land(1, 1, Orientation.S);

			_rover.Backwards();

			_rover.X.Should().Be(1);
			_rover.Y.Should().Be(2);
		}

		[Test]
		public void MovesBackwardsEastByOneCellIfOrientationIsWest()
		{
			_rover.Land(1, 1, Orientation.W);

			_rover.Backwards();

			_rover.X.Should().Be(2);
			_rover.Y.Should().Be(1);
		}

		[Test]
		[TestCase(Orientation.N)]
		[TestCase(Orientation.E)]
		[TestCase(Orientation.S)]
		[TestCase(Orientation.W)]
		public void MaintainsOrientationWhenMovingForward(Orientation orientation)
		{
			_rover.Land(0, 0, orientation);

			_rover.Forward();

			_rover.Orientation.Should().Be(orientation);
		}

		[Test]
		[TestCase(Orientation.N)]
		[TestCase(Orientation.E)]
		[TestCase(Orientation.S)]
		[TestCase(Orientation.W)]
		public void MaintainsOrientationWhenMovingBackwards(Orientation orientation)
		{
			_rover.Land(0, 0, orientation);

			_rover.Backwards();

			_rover.Orientation.Should().Be(orientation);
		}

		[Test]
		public void FacesEastAfterRotatingRightFromNorthOrientation()
		{
			_rover.Land(0, 0, Orientation.N);

			_rover.RotateRight();

			_rover.Orientation.Should().Be(Orientation.E);
		}

		[Test]
		public void FacesSouthAfterRotatingRightFromEastOrientation()
		{
			_rover.Land(0, 0, Orientation.E);

			_rover.RotateRight();

			_rover.Orientation.Should().Be(Orientation.S);
		}
	}
}
