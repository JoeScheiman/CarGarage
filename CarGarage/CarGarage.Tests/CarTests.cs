using System;
using Xunit;


namespace CarGarage.Tests
{
    public class CarTests
    {
        [Fact]
        public void shouldAccelerate()
        {
            // Tests Accelerate() method in Car increases Speed
            // Arrange
            var firstCar = new Car();
            // Act
            if (!firstCar.IsStarted()) firstCar.ToggleEngine();//Can't accelerate without engine running
            firstCar.Accelerate();
            // Assert
            Assert.Equal(10, firstCar.Speed);
        }

        [Fact]
        public void shouldConsumeFuel()
        {
            // Tests Accelerate() method reduces Fuel amount
            // Arrange
            var car = new Car();
            // Act
            if (!car.IsStarted()) car.ToggleEngine();
            car.Accelerate();
            // Assert
            Assert.Equal(90, car.GasLevel);
        }

        [Fact]
        public void shouldRefuel()
        {
            // Tests AddFuel() method increases Fuel amount
            // Arrange
            var car = new Car(50);
            // Act
            car.AddFuel();
            // Assert
            Assert.Equal(100, car.GasLevel);
        }

        [Fact]
        public void shouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            // Arrange
            var car = new Car();
            // Act
            car.Accelerate();
            car.Brake();
            // Assert
            Assert.Equal(0, car.Speed);
        }

        [Fact]
        public void shouldStart()
        {
            // Tests ToggleEngine() method starts car when its off
            // Arrange
            var car = new Car();
            // Act
            car.ToggleEngine();
            // Assert
            
            Assert.True(car.CarStarted);
        }

        [Fact]
        public void shouldTurnOff()
        {
            // Tests ToggleEngine() method turns car off when its on
            // Arrange
            var car = new Car();
            // Act
            car.ToggleEngine();
            car.ToggleEngine();
            // Assert
            Assert.False(car.CarStarted);
        }
        [Fact]
        public void getCarMake()
        {
            //Arrange
            var car = new Car("Ford", "F-150");

            //Act
            string theMake = car.GetMake();

            //Assert
            Assert.Equal("Ford", theMake);
        }
        [Fact]
        public void getCarModel()
        {
            //Arrange
            var car = new Car("Ford", "F-150");

            //Act
            string theModel = car.GetModel();

            //Assert
            Assert.Equal("F-150", theModel);
        }
        [Fact]
        public void getCarFuelLevel()
        {
            //Arrange
            var car = new Car("Ford", "F-150");

            //Act
            car.ToggleEngine(); //Cannot accelerate and use fuel if engine isn't running
            car.Accelerate();
            int fuel = car.GetFuelLevel();

            //Assert
            Assert.Equal(90, fuel);
        }
        [Fact]
        public void getCarSpeed()
        {
            //Arrange
            var car = new Car("Ford", "F-150");

            //Act
            if (!car.IsStarted()) car.ToggleEngine();
            car.Accelerate();
            int speed = car.GetSpeed();

            //Assert
            Assert.Equal(10, speed);
        }
        [Fact]
        public void getEngineStartedStatus()
        {
            //Arrange
            var car = new Car("Ford", "F-150");

            //Act
            if (!car.IsStarted()) car.ToggleEngine();
            car.Accelerate();
            int speed = car.GetSpeed();

            //Assert
            Assert.Equal(10, speed);
        }
    }
}
