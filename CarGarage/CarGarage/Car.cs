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

        public void Accelerate()
        {
            Speed += 10;
            GasLevel -= 10;
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
    }
}
