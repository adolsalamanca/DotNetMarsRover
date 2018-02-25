using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Direction;
using NUnit.Framework;

namespace MarsRover.Test
{
    public class VehicleMovementLimitTests
    {
        private List<IDirection> _listOfDirections;
        private int _xPoint, _yPoint;
        private EdgeLimits _limits;
        private Vehicle _vehicle;

        [SetUp]
        public void SetUp()
        {
            _limits = new EdgeLimits(0, 0, 0, 0);
        }

        [TearDown]
        public void TearDown()
        {
            _listOfDirections = null;
            _vehicle = null;
            _limits = null;
        }

        
       [Test]
        public void VehicleNorthOrientedGoesForward_ButIsAlreadyInTheLimit_ThenCannotMove()
        {
            //Arrange
            int oldPosition = _vehicle.Y_Point;
            
            _vehicle = new Vehicle(0,0, new NorthDirection(),_limits);
            
            //Act
            _vehicle.MoveForward();

            //Assert

            Assert.AreEqual(oldPosition, _vehicle.Y_Point);
        }

        [Test]
        public void VehicleNorthOrientedGoesBackward_ButIsAlreadyInTheLimit_ThenCannotMove()
        {
            //Arrange
            int oldPosition = _vehicle.Y_Point;

            _vehicle = new Vehicle(0, 0, new NorthDirection(), _limits);

            //Act
            _vehicle.MoveBackward();

            //Assert

            Assert.AreEqual(oldPosition, _vehicle.Y_Point);
        }

        [Test]
        public void VehicleSouthOrientedGoesForward_ButIsAlreadyInTheLimit_ThenCannotMove()
        {
            //Arrange
            _vehicle = new Vehicle(0, 0, new SouthDirection(), _limits);
            int oldPosition = _vehicle.Y_Point;

            //Act
            _vehicle.MoveForward();

            //Assert
            Assert.AreEqual(oldPosition, _vehicle.Y_Point);
        }


        [Test]
        public void VehicleSouthOrientedGoesBackward_ButIsAlreadyInTheLimit_ThenCannotMove()
        {
            //Arrange
            _vehicle = new Vehicle(0, 0, new SouthDirection(), _limits);
            int oldPosition = _vehicle.Y_Point;

            //Act
            _vehicle.MoveBackward();

            //Assert
            Assert.AreEqual(oldPosition, _vehicle.Y_Point);
        }

        [Test]
        public void VehicleEasthOrientedGoesForward_ButIsAlreadyInTheLimit_ThenCannotMove()
        {
            //Arrange
            _vehicle = new Vehicle(0, 0, new EastDirection(), _limits);
            int oldPosition = _vehicle.Y_Point;

            //Act
            _vehicle.MoveForward();

            //Assert

            Assert.AreEqual(oldPosition, _vehicle.X_Point);
        }

        [Test]
        public void VehicleEasthOrientedGoesBackward_ButIsAlreadyInTheLimit_ThenCannotMove()
        {
            //Arrange
            _vehicle = new Vehicle(0, 0, new EastDirection(), _limits);
            int oldPosition = _vehicle.Y_Point;

            //Act
            _vehicle.MoveBackward();

            //Assert

            Assert.AreEqual(oldPosition, _vehicle.X_Point);
        }

        [Test]
        public void VehicleWestOrientedGoesForward_ButIsAlreadyInTheLimit_ThenCannotMove()
        {
            //Arrange
            _vehicle = new Vehicle(0, 0, new WestDirection(), _limits);
            int oldPosition = _vehicle.Y_Point;

            //Act
            _vehicle.MoveForward();

            //Assert

            Assert.AreEqual(oldPosition, _vehicle.X_Point);
        }


        [Test]
        public void VehicleWestOrientedGoesBackward_ButIsAlreadyInTheLimit_ThenCannotMove()
        {
            //Arrange
            _vehicle = new Vehicle(0, 0, new WestDirection(), _limits);
            int oldPosition = _vehicle.Y_Point;

            //Act
            _vehicle.MoveBackward();

            //Assert

            Assert.AreEqual(oldPosition, _vehicle.X_Point);
        }

    }
}
