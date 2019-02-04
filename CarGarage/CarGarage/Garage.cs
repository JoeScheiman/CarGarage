using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> TheGarage;

        public Garage()
        {
            TheGarage = new List<Car>();

        }
        public void AddCar()
        {
            //Car newCar = new Car();
            TheGarage.Add(new Car());

        }
        public void RemoveCar()
        {
            if (TheGarage.Count >= 1)
            {
                TheGarage.RemoveAt(TheGarage.Count - 1);
                if (TheGarage.Count != TheGarage.Capacity)
                {
                    TheGarage.TrimExcess();
                }
            }
        }
        public void FuelAllCars()
        {
            foreach (Car someCar in TheGarage)
            {
                someCar.AddFuel();
            }
        }
        /*public bool RemoveCar()
        {
            if (TheGarage.Count >= 1)
            {
                TheGarage.RemoveAt(TheGarage.Count);
                return (true);
            }
            else
            {
                return (false);
            }
        }*/



    }
}
