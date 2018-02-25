   
using MarsRover.Direction;
using NUnit.Framework;

namespace MarsRover.Test
{
    [TestFixture]
    public class VehicleMovementTests
    {
        private int _xPoint, _yPoint;
        private Coordinates _orientation;
        private EdgeLimits _limits;
        private Vehicle _vehicle;

        [SetUp]
        public void SetUp()
        {
            _xPoint = 123;
            _yPoint = 567;
            _limits = new EdgeLimits(8888,8888,8888,8888);
        }

        [TearDown]
        public void TearDown()
        {
            _xPoint = 0;
            _yPoint = 0;
            _limits = null;
            _vehicle = null;
        }

        [Test]
        public void VehicleGoesForward__IfIsNorthOriented_ThenGoesUp()
        {
            //Arrange
            _orientation = Coordinates.North;
            _vehicle = new Vehicle(_xPoint, _yPoint, new NorthDirection(), _orientation, _limits);

            //Act
            _vehicle.MoveForward();

            //Assert
            Assert.IsTrue(_vehicle.Y_Point == _yPoint+1);
            
        }

        [Test]
        public void VehicleGoesForward__IfIsNorthOriented_ThenGoesDown()
        {
            //Arrange
            _orientation = Coordinates.South;
            _vehicle = new Vehicle(_xPoint, _yPoint, new NorthDirection(), _orientation, _limits);

            //Act
            _vehicle.MoveBackward();

            //Assert
            Assert.IsTrue(_vehicle.Y_Point == _yPoint -1);

        }

        [Test]
        public void VehicleGoesForward__IfIsSouthOriented_ThenGoesDown()
        {
            //Arrange
            _orientation = Coordinates.South;
            _vehicle = new Vehicle(_xPoint, _yPoint, new SouthDirection(), _orientation, _limits);

            //Act
            _vehicle.MoveForward();

            //Assert
            Assert.IsTrue(_vehicle.Y_Point == _yPoint - 1);

        }

        [Test]
        public void VehicleGoesForward__IfIsSouthOriented_ThenGoesUp()
        {
            //Arrange
            _orientation = Coordinates.South;
            _vehicle = new Vehicle(_xPoint, _yPoint, new SouthDirection(), _orientation, _limits);

            //Act
            _vehicle.MoveBackward();

            //Assert
            Assert.IsTrue(_vehicle.Y_Point == _yPoint + 1);

        }


        [Test]
        public void VehicleGoesForward__IfIsEastOriented_ThenGoesRight()
        {
            //Arrange
            _orientation = Coordinates.South;
            _vehicle = new Vehicle(_xPoint, _yPoint, new EastDirection(), _orientation, _limits);

            //Act
            _vehicle.MoveForward();

            //Assert
            Assert.IsTrue(_vehicle.X_Point == _xPoint + 1);

        }

        [Test]
        public void VehicleGoesBackward__IfIsEastOriented_ThenGoesLeft()
        {
            //Arrange
            _orientation = Coordinates.South;
            _vehicle = new Vehicle(_xPoint, _yPoint, new EastDirection(), _orientation, _limits);

            //Act
            _vehicle.MoveBackward();

            //Assert
            Assert.IsTrue(_vehicle.X_Point == _xPoint - 1);

        }

        [Test]
        public void VehicleGoesForward__IfIsWestOriented_ThenGoesLeft()
        {
            //Arrange
            _orientation = Coordinates.South;
            _vehicle = new Vehicle(_xPoint, _yPoint, new WestDirection(), _orientation, _limits);

            //Act
            _vehicle.MoveForward();

            //Assert
            Assert.IsTrue(_vehicle.X_Point == _xPoint - 1);

        }

        [Test]
        public void VehicleGoesBackward__IfIsWestOriented_ThenGoesRight()
        {
            //Arrange
            _orientation = Coordinates.South;
            _vehicle = new Vehicle(_xPoint, _yPoint, new WestDirection(), _orientation, _limits);

            //Act
            _vehicle.MoveBackward();

            //Assert
            Assert.IsTrue(_vehicle.X_Point == _xPoint + 1);

        }

    }
}