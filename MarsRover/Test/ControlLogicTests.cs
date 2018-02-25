using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Direction;
using NUnit.Framework;

namespace MarsRover.Test
{
    public class ControlLogicTests
    {
        private int _xPoint, _yPoint;
        private ControlLogic _controlLogic;
        private IDirection _direction;
        private Vehicle _vehicle;
        private EdgeLimits _restrictiveLimits,_permissiveLimits;
        private List<Obstacle> _obstaclesEmptyList, _obstaclesWithItems;
        private List<Command> _commandList;

        [SetUp]
        public void SetUp()
        {
            _xPoint = 0;
            _yPoint = 0;

            _restrictiveLimits = new EdgeLimits(0,0,0,0);
            _obstaclesEmptyList = new List<Obstacle>();
            _obstaclesWithItems = new List<Obstacle>()
            {
                new Obstacle(0,1),
                new Obstacle(1,0),
                new Obstacle(0,-1),
                new Obstacle(-1,0)
            };

            _permissiveLimits = new EdgeLimits(8888, 8888, 8888, 8888);
            _commandList = new List<Command>()
            {
                Command.F,
                Command.F,
                Command.B,
            };

        }

        [TearDown]
        public void TearDown()
        {
            _vehicle = null;
        }

        
       [Test]
        public void VehicleNorthOrientedGoesForward_ButIsAlreadyInTheLimit_ThenCannotMove()
        {
            //Arrange
            _direction = new NorthDirection();
            _vehicle = new Vehicle(_xPoint, _yPoint, _direction);
            _controlLogic = new ControlLogic(_vehicle, _restrictiveLimits, _obstaclesEmptyList);

            //Act
            _controlLogic.ExecuteCommands(_commandList);

            //Assert
            Assert.AreEqual(_vehicle.X_Point, _xPoint);
            Assert.AreEqual(_vehicle.Y_Point, _yPoint);

        }

        [Test]
        public void VehicleSouthOrientedGoesForward_ButIsAlreadyInTheLimit_ThenCannotMove()
        {
            //Arrange
            _direction = new SouthDirection();
            _vehicle = new Vehicle(_xPoint, _yPoint, _direction);
            _controlLogic = new ControlLogic(_vehicle, _restrictiveLimits, _obstaclesEmptyList);

            //Act
            _controlLogic.ExecuteCommands(_commandList);

            //Assert
            Assert.AreEqual(_vehicle.X_Point, _xPoint);
            Assert.AreEqual(_vehicle.Y_Point, _yPoint);

        }

        [Test]
        public void VehicleEastOrientedGoesForward_ButIsAlreadyInTheLimit_ThenCannotMove()
        {
            //Arrange
            _direction = new EastDirection();
            _vehicle = new Vehicle(_xPoint, _yPoint, _direction);
            _controlLogic = new ControlLogic(_vehicle, _restrictiveLimits, _obstaclesEmptyList);

            //Act
            _controlLogic.ExecuteCommands(_commandList);

            //Assert
            Assert.AreEqual(_vehicle.X_Point, _xPoint);
            Assert.AreEqual(_vehicle.Y_Point, _yPoint);

        }

        [Test]
        public void VehicleWestOrientedGoesForward_ButIsAlreadyInTheLimit_ThenCannotMove()
        {
            //Arrange
            _direction = new WestDirection();
            _vehicle = new Vehicle(_xPoint, _yPoint, _direction);
            _controlLogic = new ControlLogic(_vehicle, _restrictiveLimits, _obstaclesEmptyList);

            //Act
            _controlLogic.ExecuteCommands(_commandList);

            //Assert
            Assert.AreEqual(_vehicle.X_Point, _xPoint);
            Assert.AreEqual(_vehicle.Y_Point, _yPoint);

        }

        [Test]
        public void VehicleNorthOrientedGoesForward_ButThereAreObstacles_ThenCannotMove()
        {
            //Arrange
            _direction = new NorthDirection();
            _vehicle = new Vehicle(_xPoint, _yPoint, _direction);
            _controlLogic = new ControlLogic(_vehicle, _permissiveLimits, _obstaclesWithItems);

            //Act
            _controlLogic.ExecuteCommands(_commandList);

            //Assert
            Assert.AreEqual(_vehicle.X_Point, _xPoint);
            Assert.AreEqual(_vehicle.Y_Point, _yPoint);

        }

        [Test]
        public void VehicleSouthOrientedGoesForward_ButThereAreObstacles_ThenCannotMove()
        {
            //Arrange
            _direction = new SouthDirection();
            _vehicle = new Vehicle(_xPoint, _yPoint, _direction);
            _controlLogic = new ControlLogic(_vehicle, _permissiveLimits, _obstaclesWithItems);

            //Act
            _controlLogic.ExecuteCommands(_commandList);

            //Assert
            Assert.AreEqual(_vehicle.X_Point, _xPoint);
            Assert.AreEqual(_vehicle.Y_Point, _yPoint);

        }

        [Test]
        public void VehicleEastOrientedGoesForward_ButThereAreObstacles_ThenCannotMove()
        {
            //Arrange
            _direction = new EastDirection();
            _vehicle = new Vehicle(_xPoint, _yPoint, _direction);
            _controlLogic = new ControlLogic(_vehicle, _permissiveLimits, _obstaclesWithItems);

            //Act
            _controlLogic.ExecuteCommands(_commandList);

            //Assert
            Assert.AreEqual(_vehicle.X_Point, _xPoint);
            Assert.AreEqual(_vehicle.Y_Point, _yPoint);

        }

        [Test]
        public void VehicleWestOrientedGoesForward_ButThereAreObstacles_ThenCannotMove()
        {
            //Arrange
            _direction = new WestDirection();
            _vehicle = new Vehicle(_xPoint, _yPoint, _direction);
            _controlLogic = new ControlLogic(_vehicle, _permissiveLimits, _obstaclesWithItems);

            //Act
            _controlLogic.ExecuteCommands(_commandList);

            //Assert
            Assert.AreEqual(_vehicle.X_Point, _xPoint);
            Assert.AreEqual(_vehicle.Y_Point, _yPoint);

        }


        [Test]
        public void VehicleNorthOrientedGoesForward_ButIsNotInTheLimit_ThenItCanMove()
        {
            //Arrange
            _direction = new NorthDirection();
            _vehicle = new Vehicle(_xPoint, _yPoint, _direction);
            _controlLogic = new ControlLogic(_vehicle, _permissiveLimits, _obstaclesEmptyList);

            //Act
            _controlLogic.ExecuteCommands(_commandList);

            //Assert
            Assert.AreNotEqual(_vehicle.Y_Point, _yPoint);

        }

        [Test]
        public void VehicleSouthOrientedGoesForward_ButIsNotInTheLimit_ThenItCanMove()
        {
            //Arrange
            _direction = new SouthDirection();
            _vehicle = new Vehicle(_xPoint, _yPoint, _direction);
            _controlLogic = new ControlLogic(_vehicle, _permissiveLimits, _obstaclesEmptyList);

            //Act
            _controlLogic.ExecuteCommands(_commandList);

            //Assert
            Assert.AreNotEqual(_vehicle.Y_Point, _yPoint);
        }

        [Test]
        public void VehicleEastOrientedGoesForward_ButIsNotInTheLimit_ThenItCanMove()
        {
            //Arrange
            _direction = new EastDirection();
            _vehicle = new Vehicle(_xPoint, _yPoint, _direction);
            _controlLogic = new ControlLogic(_vehicle, _permissiveLimits, _obstaclesEmptyList);

            //Act
            _controlLogic.ExecuteCommands(_commandList);

            //Assert
            Assert.AreNotEqual(_vehicle.X_Point, _xPoint);

        }

        [Test]
        public void VehicleWestOrientedGoesForward_ButIsNotInTheLimit_ThenItCanMove()
        {
            //Arrange
            _direction = new WestDirection();
            _vehicle = new Vehicle(_xPoint, _yPoint, _direction);
            _controlLogic = new ControlLogic(_vehicle, _permissiveLimits, _obstaclesEmptyList);

            //Act
            _controlLogic.ExecuteCommands(_commandList);

            //Assert
            Assert.AreNotEqual(_vehicle.X_Point, _xPoint);

        }
    }
}
