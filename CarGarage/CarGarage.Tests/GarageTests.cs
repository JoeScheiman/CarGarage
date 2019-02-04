using System;
using Xunit;

namespace CarGarage.Tests
{
    public class GarageTests
    {
        [Fact]
        public void shouldAddCarToGarage()
        {
            // Tests AddCar() method
            // Arrange
            var xxx = new Garage();
            // Act
            xxx.AddCar();
            // Assert
            Assert.NotEmpty(xxx.TheGarage);
        }

        [Fact]
        public void shouldRemoveCarFromGarage()
        {
            // Tests RemoveCar() method
            // Arrange
            var xxx = new Garage();
            // Act
            xxx.AddCar();
            xxx.RemoveCar();
            // Assert
            Assert.Empty(xxx.TheGarage);
            
        }

        [Fact]
        public void shouldFuelAllCars()
        {
            // Tests FuelAllCars() method
            // Arrange
            var xxx = new Garage();
            // Act
            int numCars = 4;
            for (int i = 0; i < numCars; i++) xxx.AddCar(); //add numCars cars
            for (int p = 0; p < numCars; p++) xxx.TheGarage[p].Accelerate(); //uses gas

            xxx.FuelAllCars();

            int totalFuel = 0; 
            foreach (Car theCar in xxx.TheGarage)
            {
                totalFuel += theCar.GasLevel;
            }

            // Assert
            Assert.Equal(numCars * 100, totalFuel);
        }

        [Fact]
        public void shouldTestDriveOneCar()
        {
            // Use the Program class to let you select a single car
            // Program class should then let you choose what you want to do with that car
            // You do not need to test user input in the Program class
        }

        [Fact]
        public void youShouldNameThisTest()
        {
            // Should be able to list stats of all cars
            // Create necessary method(s)
            // Garage class should provide cars
            // Program class should list all stats
        }
    }
}
