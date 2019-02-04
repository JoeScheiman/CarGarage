using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> TheGarage;
        public int CurrentCar;

        public Garage()
        {
            TheGarage = new List<Car>();

        }
        public void AddCar()
        {
            //Car newCar = new Car();
            TheGarage.Add(new Car());

        }
        public void AddCar(string make, string model)
        {
            //Car newCar = new Car();
            TheGarage.Add(new Car(make, model));

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
        public void RemoveCar(int x)
        {
            if (TheGarage.Count >= 1 && x < TheGarage.Count)
            {
                TheGarage.RemoveAt(x);
                if (TheGarage.Count != TheGarage.Capacity)
                {
                    TheGarage.TrimExcess();
                }
            }
        }
        public void RemoveCarByMakeAndModel(string make, string model)
        {
            bool worked = false;
            for (int p=0; p<TheGarage.Count; p++)
            {
                if ( make.Equals(TheGarage[p].GetMake()) && model.Equals(TheGarage[p].GetModel()))      
                {
                    TheGarage.RemoveAt(p);
                    Console.WriteLine("Successfully Removed " + make + ", " + model);
                    worked = true;
                }
            }
            if (TheGarage.Count != TheGarage.Capacity)
            {
                TheGarage.TrimExcess();
            }
            if (!worked)
            {
                Console.WriteLine("Didn't Work! Car Wasn't in Garage!");
            }
        }

        public void FuelAllCars()
        {
            bool worked = false;
            foreach (Car someCar in TheGarage)
            {
                someCar.AddFuel();
                worked = true;
            }
            if (worked)
                Console.WriteLine("All Cars Refueled!");
            else
                Console.WriteLine("No Cars Refueled!");
        }
        /*public void DisplayAllStatsOfCar(int x)
        {
            if (TheGarage.Count > 0)
            {
                foreach (Car theCar in TheGarage)
                {

                }
            }
        }*/
        public void DisplayAllStatsOfCar(string make, string model)
        {
            for (int p = 0; p < TheGarage.Count; p++)
            {
                if (make.Equals(TheGarage[p].GetMake()) && model.Equals(TheGarage[p].GetModel()))
                {
                    string printMake = TheGarage[p].GetMake().PadRight(12);
                    string printModel = TheGarage[p].GetModel().PadRight(12);
                    string running = TheGarage[p].IsStarted().ToString().PadRight(10);
                    string gas = TheGarage[p].GetFuelLevel().ToString().PadRight(10);
                    string speed = TheGarage[p].GetSpeed().ToString().PadRight(10);
                    Console.Write(printMake+printModel+running+gas+speed);
                    p = TheGarage.Count; // get out of for loop
                }
            }
        }
        public void DisplayAllStatsOfCar(int index)
        {
            
                if ((index >= 0)&&(index < TheGarage.Count))
                {
                    string printMake = TheGarage[index].GetMake().PadRight(12);
                    string printModel = TheGarage[index].GetModel().PadRight(12);
                    string running = TheGarage[index].IsStarted().ToString().PadRight(10);
                    string gas = TheGarage[index].GetFuelLevel().ToString().PadRight(10);
                    string speed = TheGarage[index].GetSpeed().ToString().PadRight(10);
                    Console.Write(printMake + printModel + running + gas + speed);
                    
                }
            else
            {
                Console.WriteLine("Car Doesn't Exist");
            }
            
        }
        public string AllStatsofCarToString(int index)
        {
            if ((index >= 0)&&(index < TheGarage.Count))
            {
                string printMake = TheGarage[index].GetMake().PadRight(12);
                string printModel = TheGarage[index].GetModel().PadRight(12);
                string running = TheGarage[index].IsStarted().ToString().PadRight(10);
                string gas = TheGarage[index].GetFuelLevel().ToString().PadRight(10);
                string speed = TheGarage[index].GetSpeed().ToString().PadRight(10);
                return(printMake + printModel + running + gas + speed);

            }
            else
            {
                return ("Car Doesn't Exist");
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
