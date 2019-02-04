using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        private readonly int FullTank = 100;
        public int Speed { get; private set; }
        public int GasLevel { get; private set; }
        public bool CarStarted { get; private set; }
        public string CarMake { get; private set; }
        public string CarModel { get; private set; }

        public Car()
        {
            Speed = 0;
            GasLevel = FullTank;
            CarStarted = false;
        }
        public Car(int startGasLevel)
        {
            Speed = 0;
            GasLevel = startGasLevel;
            CarStarted = false;
        }
        public Car(string make, string model)
        {
            Speed = 0;
            GasLevel = 100;
            CarStarted = false;
            CarMake = make;
            CarModel = model;
        }

        public void Accelerate()
        {
            if (CarStarted)
            {
                Speed += 10;
                GasLevel -= 10;
            }
        }
        public void AddFuel()
        {
            GasLevel = FullTank;
        }
        public void Brake()
        {
            Speed -= 10;
            if (Speed < 0)
            {
                Speed = 0;
            }
        }
        public void ToggleEngine()
        {
            CarStarted = !CarStarted;
        }
        public string GetMake()
        {
            return (CarMake);
        }
        public string GetModel()
        {
            return (CarModel);
        }
        public int GetSpeed()
        {
            return (Speed);
        }
        public int GetFuelLevel()
        {
            return (GasLevel);
        }
        public bool IsStarted()
        {
            return (CarStarted);
        }
    }
}
