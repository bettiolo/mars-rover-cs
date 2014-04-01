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

		[TestCase(Orientation.N)]
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

			_rover.MoveForward();

			_rover.X.Should().Be(0);
			_rover.Y.Should().Be(1);
		}

		[Test]
		public void MovesForwardEastByOneCellIfOrientationIsEast()
		{
			_rover.Land(1, 1, Orientation.E);

			_rover.MoveForward();

			_rover.X.Should().Be(2);
			_rover.Y.Should().Be(1);
		}

		[Test]
		public void MovesForwardSouthByOneCellIfOrientationIsSouth()
		{
			_rover.Land(2, 2, Orientation.S);

			_rover.MoveForward();

			_rover.X.Should().Be(2);
			_rover.Y.Should().Be(1);
		}

		[Test]
		public void MovesForwardWestByOneCellIfOrientationIsWest()
		{
			_rover.Land(3, 3, Orientation.W);

			_rover.MoveForward();

			_rover.X.Should().Be(2);
			_rover.Y.Should().Be(3);
		}

		[Test]
		public void MovesBackwardsSouthByOneCellIfOrientationIsNorth()
		{
			_rover.Land(1,1, Orientation.N);

			_rover.MoveBackward();

			_rover.X.Should().Be(1);
			_rover.Y.Should().Be(0);
		}

		[Test]
		public void MovesBackwardsWestByOneCellIfOrientationIsEast()
		{
			_rover.Land(1, 1, Orientation.E);

			_rover.MoveBackward();

			_rover.X.Should().Be(0);
			_rover.Y.Should().Be(1);
		}

		[Test]
		public void MovesBackwardsNorthByOneCellIfOrientationIsSouth()
		{
			_rover.Land(1, 1, Orientation.S);

			_rover.MoveBackward();

			_rover.X.Should().Be(1);
			_rover.Y.Should().Be(2);
		}

		[Test]
		public void MovesBackwardsEastByOneCellIfOrientationIsWest()
		{
			_rover.Land(1, 1, Orientation.W);

			_rover.MoveBackward();

			_rover.X.Should().Be(2);
			_rover.Y.Should().Be(1);
		}

		[TestCase(Orientation.N)]
		[TestCase(Orientation.E)]
		[TestCase(Orientation.S)]
		[TestCase(Orientation.W)]
		public void MaintainsOrientationWhenMovingForward(Orientation orientation)
		{
			_rover.Land(0, 0, orientation);

			_rover.MoveForward();

			_rover.Orientation.Should().Be(orientation);
		}

		[TestCase(Orientation.N)]
		[TestCase(Orientation.E)]
		[TestCase(Orientation.S)]
		[TestCase(Orientation.W)]
		public void MaintainsOrientationWhenMovingBackwards(Orientation orientation)
		{
			_rover.Land(0, 0, orientation);

			_rover.MoveBackward();

			_rover.Orientation.Should().Be(orientation);
		}

		[TestCase(Orientation.N, Orientation.E)]
		[TestCase(Orientation.E, Orientation.S)]
		[TestCase(Orientation.S, Orientation.W)]
		[TestCase(Orientation.W, Orientation.N)]
		public void FacesCorrectOrientationAfterRotatingRight(Orientation startingOrientation, Orientation expectedOrientation)
		{
			_rover.Land(0, 0, startingOrientation);

			_rover.RotateRight();

			_rover.Orientation.Should().Be(expectedOrientation);
		}

		[TestCase(Orientation.N, Orientation.W)]
		[TestCase(Orientation.E, Orientation.N)]
		[TestCase(Orientation.S, Orientation.E)]
		[TestCase(Orientation.W, Orientation.S)]
		public void FacesCorrectOrientationAfterRotatingLeft(Orientation startingOrientation, Orientation expectedOrientation)
		{
			_rover.Land(0, 0, startingOrientation);

			_rover.RotateLeft();

			_rover.Orientation.Should().Be(expectedOrientation);
		}

		[Test]
		public void DoesNotMoveWhenRotatingRight()
		{
			_rover.Land(3, 3, Orientation.N);

			_rover.RotateRight();

			_rover.X.Should().Be(3);
			_rover.Y.Should().Be(3);
		}

		[Test]
		public void DoesNotMoveWhenRotatingLeft()
		{
			_rover.Land(2, 2, Orientation.S);

			_rover.RotateLeft();

			_rover.X.Should().Be(2);
			_rover.Y.Should().Be(2);
		}
	}
}
