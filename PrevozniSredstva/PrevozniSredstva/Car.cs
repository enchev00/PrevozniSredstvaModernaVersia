using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevozniSredstva
{
    public class Car
    {
        public Car (string carname,double fuel,double fuelconsumption)
        {
            this.CarName = carname;
            this.Fuel = fuel;
            this.FuelConsumption= fuelconsumption;
            }
        public string CarName { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption  { get; set;}

        

        public void driveCar(double distanceTravelled, string[] komandi)
        {
            



            if (komandi[0] == "Drive")
            {

                if (komandi[1] == "Car")
                {
                    double distanceAvailableCar;
                    double izrazhodenoCar;
                    distanceAvailableCar = Fuel * FuelConsumption;

                    if (distanceAvailableCar > double.Parse(komandi[2]))
                    {
                        izrazhodenoCar = FuelConsumption * double.Parse(komandi[2]);

                        Console.WriteLine(CarName + " travelled " + distanceTravelled + " km");
                        Fuel = Fuel - izrazhodenoCar;

                    }
                    else
                    {
                        Console.WriteLine("Car needs refueling");
                    }
                }

                


            }

            if (komandi[0] == "Refuel")
            {
                if (komandi[1] == "Car")
                {
                    Fuel = Fuel + double.Parse(komandi[2]);
                }
                
            }
        }

        public void printDetails()
        {
            Console.WriteLine("Car Name is: " +CarName + " ,has " + Fuel + " and its fuel consumption is " + FuelConsumption);
        }
        public void fuelCar()
        {
            
        }
    }
}
