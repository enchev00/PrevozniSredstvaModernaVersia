using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevozniSredstva
{
    public class Truck
    {

        public Truck(string truckname, double fuel, double fuelconsumption) {
            this.TruckName = truckname;
            this.Fuel = fuel;
            this.FuelConsumption= fuelconsumption;
        }

        public string TruckName { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }


        public void driveTruck(double distanceTravelled, string[] komandi)
        {

 

            if (komandi[0] == "Drive")
            {

                if (komandi[1] == "Truck")
                {
                    double distanceAvailableTruck;
                    double izrazhodenoTruck;
                    distanceAvailableTruck = Fuel * FuelConsumption;

                    if (distanceAvailableTruck > double.Parse(komandi[2]))
                    {
                        izrazhodenoTruck = FuelConsumption * double.Parse(komandi[2]);

                        Console.WriteLine(TruckName + " travelled " + distanceTravelled + " km");
                        Fuel = Fuel - izrazhodenoTruck;

                    }
                    else
                    {
                        Console.WriteLine("Truck needs refueling");
                    }
                }
            }

            if (komandi[0] == "Refuel")
            {
                if (komandi[1] == "Truck")
                {
                    Fuel = Fuel + double.Parse(komandi[2]);
                    Fuel = 0.95 * Fuel;
                }
                
            }

        }
    }
}

