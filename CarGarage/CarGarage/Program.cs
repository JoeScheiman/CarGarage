using System;

namespace CarGarage
{
    class Program
    {

        //It is very open to your interpretation, but it could look something like below, which basically gives the user the ability to interact with all the methods you created->

        //A example Main menu to interact with the garage:
        //1. Add a Car to the Garage
        //2. Remove a Car from the Garage
        //3. List all Cars
        //4. Test drive a car
        //5. Refuel all cars

        //And then a sub menu to interact with the car that was selected(under 4. Test drive a car):
        //1. Turn on car
        //2. Accelerate
        //3. Brake
        //4. Turn off car
        //5. Return car
        static void Main(string[] args)
        {
            Garage joeGarage = new Garage();
            
            int selection = 0;

            restartMainMenu();
            do
            {
                
                var input = Console.ReadKey(false).Key;
                switch (input)
                {
                    case ConsoleKey.D1: //the D1 means "1" above the q key and Numpad1 means "1" on num pad!
                    case ConsoleKey.NumPad1: //once you're in the switch, it continues until a break, so D1 or NumPad1 
                        //Console.WriteLine("Decision Has Been Made!!! - 1\n");
                        selection = 1;
                        Console.WriteLine("Add a Car to the Garage!\n");
                        Console.Write("\tEnter Make: ");
                        string theMake = Console.ReadLine();
                        Console.Write("\n\tEnter Model: ");
                        string theModel = Console.ReadLine();
                        joeGarage.AddCar(theMake, theModel);
                        restartMainMenu();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //Console.WriteLine("Decision Has Been Made!!! - 2\n");
                        selection = 2;
                        Console.WriteLine("Remove a Car from the Garage!\n");
                        Console.Write("\tEnter Make: ");
                        string theRemovedMake = Console.ReadLine();
                        Console.Write("\n\tEnter Model: ");
                        string theRemovedModel = Console.ReadLine();
                        joeGarage.RemoveCarByMakeAndModel(theRemovedMake, theRemovedModel);
                        Console.WriteLine("\n...Press Enter to Continue");
                        Console.ReadLine();
                        restartMainMenu();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        //Console.WriteLine("Decision Has Been Made!!! - 3\n");
                        selection = 3;
                        Console.WriteLine("  MAKE        MODEL       RUNNING?  FUEL      SPEED");
                        for (int car=0; car<joeGarage.TheGarage.Count; car++)
                        {
                            Console.WriteLine(car + " " + joeGarage.AllStatsofCarToString(car));
                        }
                        Console.WriteLine("\n...Press Enter to Continue");
                        Console.ReadLine();
                        restartMainMenu();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        //Console.WriteLine("Decision Has Been Made!!! - 4\n");
                        selection = 4;
                        carOpsMenu(ref joeGarage);
                        selection = 0;
                        restartMainMenu();
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.WriteLine("Decision Has Been Made!!! - 5\n");
                        selection = 5;
                        joeGarage.FuelAllCars();
                        Console.WriteLine("\n...Press Enter to Continue");
                        Console.ReadLine();
                        restartMainMenu();
                        break;

                    case ConsoleKey.Escape:
                        selection = 6;
                        break;

                    case ConsoleKey.Enter:
                        break;
                    default:
                        break;
                }

            } while (selection != 6);
            
        }

        public static void restartMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Joe Scheiman's Car Garage App v1");
            Console.WriteLine("1. Add a Car to the Garage");
            Console.WriteLine("2. Remove a Car from the Garage");
            Console.WriteLine("3. List all Cars");
            Console.WriteLine("4. Test drive a Car");
            Console.WriteLine("5. Refuel all Cars");
            Console.WriteLine("....Choose an option (Escape to Quit): ");
        }
        public static void carOpsMenu(ref Garage g)
        {
            int selection = -1;
            int carChoice = -1;
            if (g.TheGarage.Count > 0)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("----- TEST DRIVE -----");
                    Console.WriteLine("  MAKE        MODEL       RUNNING?  FUEL      SPEED");

                    for (int car = 0; car < g.TheGarage.Count; car++)
                    {
                        Console.WriteLine(car + " " + g.AllStatsofCarToString(car));
                    }
                    Console.Write("\n\tSelect a Car# and Press Enter :");
                    carChoice = Convert.ToInt32(Console.ReadLine());
                } while ((!(carChoice > 0)) && (!(carChoice < g.TheGarage.Count)));

                do
                {
                    Console.Clear();

                    Console.WriteLine("Test Driving the "+g.TheGarage[carChoice].GetMake()+", "+g.TheGarage[carChoice].GetModel()+"\n");
                    
                    Console.WriteLine("1. Turn Engine On");
                    Console.WriteLine("2. Accelerate");
                    Console.WriteLine("3. Brake");
                    Console.WriteLine("4. Turn Off");
                    Console.WriteLine("5. Return");
                    Console.WriteLine("....Choose an option: ");

                    var input = Console.ReadKey(false).Key;
                    switch (input)
                    {
                        case ConsoleKey.D1: //the D1 means "1" above the q key and Numpad1 means "1" on num pad!
                        case ConsoleKey.NumPad1: //once you're in the switch, it continues until a break, so D1 or NumPad1  
                            selection = 1;
                            Console.WriteLine("...Turn on the Engine!\n");
                            if(g.TheGarage[carChoice].IsStarted())
                            {
                                Console.WriteLine("!!! It's already running");
                            }
                            else
                            {
                                g.TheGarage[carChoice].ToggleEngine();
                                Console.WriteLine("Car is Running Now!");
                            }
                            Console.WriteLine("\n...Press Enter to Continue");
                            Console.ReadLine();
                            break;

                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            selection = 2;
                            Console.WriteLine("...Accelerate!\n");
                            if (g.TheGarage[carChoice].IsStarted())
                            {
                                g.TheGarage[carChoice].Accelerate();
                                Console.WriteLine(" Yep, you've accelerated!");
                                Console.WriteLine(" Current Speed is " + g.TheGarage[carChoice].GetSpeed() + " mph.");
                            }
                            else
                            {
                                Console.WriteLine("!!! Can't Accelerate, Car is NOT Running Now!");
                            }
                            Console.WriteLine("\n...Press Enter to Continue");
                            Console.ReadLine();
                            break;

                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            Console.WriteLine("...\n");
                            selection = 3;
                            Console.WriteLine("...Brake!\n");
                            int currentSpeed = g.TheGarage[carChoice].GetSpeed();
                            if (currentSpeed > 0)
                            {
                                g.TheGarage[carChoice].Brake();
                                Console.WriteLine(" Yep, you've braked! Going Slower");
                                Console.WriteLine(" Current Speed is " + g.TheGarage[carChoice].GetSpeed() + " mph.");
                            }
                            else
                            {
                                Console.WriteLine("!!! No need to break, Car is NOT moving Now!");
                            }
                            Console.WriteLine("\n...Press Enter to Continue");
                            Console.ReadLine();
                            break;

                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            selection = 4;
                            Console.WriteLine("...Turn Off Engine!\n");
                            int speed = g.TheGarage[carChoice].GetSpeed();
                            bool on = g.TheGarage[carChoice].IsStarted();
                            if (speed > 0)
                            {
                                Console.WriteLine("!!! Can't turn engine off, need to BRAKE " +(speed / 10)+ " times first.");
                            }
                            else if (!on)
                            {
                                Console.WriteLine("!!! Can't turn engine off, Car is already NOT Running Now!");
                            }
                            else
                            {
                                g.TheGarage[carChoice].ToggleEngine();
                                Console.WriteLine( "Yep, you've turned off engine");
                            }
                            Console.WriteLine("\n...Press Enter to Continue");
                            Console.ReadLine();
                            break;

                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                            selection = 5;
                            break;

                        case ConsoleKey.Escape:
                            selection = 5;
                            break;

                        case ConsoleKey.Enter:
                            break;
                        default:
                            break;
                    }

                } while (selection != 5);
            }
            else
            {
                Console.WriteLine("No Cars!");
                Console.WriteLine("Add some Cars, first - press enter to continue");
                Console.ReadLine();
            }
            return;
        }
    }
}
