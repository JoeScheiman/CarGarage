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
            this.TheGarage.Add(new Car());

        }

        
        
    }
}
