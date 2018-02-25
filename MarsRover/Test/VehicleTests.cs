   
using MarsRover.Direction;
using NUnit.Framework;

namespace MarsRover.Test
{
    [TestFixture]
    public class VehicleTests
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
        public void VehicleGoesUp__IfIsNorthOriented_AndGoesForward()
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
        public void VehicleGoesDown__IfIsNorthOriented_AndGoesBackward()
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
        public void VehicleGoesDown__IfIsSouthOriented_AndGoesForward()
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
        public void VehicleGoesUp__IfIsSouthOriented_AndGoesBackward()
        {
            //Arrange
            _orientation = Coordinates.South;
            _vehicle = new Vehicle(_xPoint, _yPoint, new SouthDirection(), _orientation, _limits);

            //Act
            _vehicle.MoveBackward();

            //Assert
            Assert.IsTrue(_vehicle.Y_Point == _yPoint + 1);

        }
    }
}