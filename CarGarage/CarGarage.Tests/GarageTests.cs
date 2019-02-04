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
            xxx.AddCar(); //add 2
            xxx.RemoveCar();
            xxx.RemoveCar(); //remove 2
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
            int numCarsThatUsedFuel = 0;
            for (int i = 0; i < numCars; i++)
            {
                xxx.AddCar(); //add a car
                xxx.TheGarage[i].ToggleEngine();//start the engine
                xxx.TheGarage[i].Accelerate();//consume some fuel
                if (xxx.TheGarage[i].GetFuelLevel() != 100) numCarsThatUsedFuel++; //make sure fuel was used
            }
            if (numCars != numCarsThatUsedFuel) Assert.Equal(numCars, numCarsThatUsedFuel);
            else
            {
                xxx.FuelAllCars();

                int totalFuel = 0;
                foreach (Car theCar in xxx.TheGarage)
                {
                    totalFuel += theCar.GetFuelLevel();
                }

                // Assert
                Assert.Equal(numCars * 100, totalFuel);
            }
        }
        [Fact]
        public void shouldRemoveCarByMakeAndModel()
        {
            var xxx = new Garage();

            xxx.AddCar("Ford", "F150");
            xxx.AddCar("Ford", "Mustang");
            xxx.AddCar("Volvo", "S60R");

            xxx.RemoveCarByMakeAndModel("Ford", "Mustang");

            Assert.Equal(2, xxx.TheGarage.Count);
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
