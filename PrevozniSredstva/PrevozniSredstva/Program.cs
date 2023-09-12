// See https://aka.ms/new-console-template for more information
using PrevozniSredstva;




double climaCar = 0.9;
double climaTruck = 1.6;
string[] carInput = Console.ReadLine().Split(" ").ToArray();
Car bmw = new Car(carInput[0], double.Parse(carInput[1]), double.Parse(carInput[2]) + climaCar);


string[] truckInput = Console.ReadLine().Split(" ").ToArray();
Truck kamion = new Truck(truckInput[0], double.Parse(truckInput[1]), double.Parse(truckInput[2]) + climaTruck);


int broiKomandi = int.Parse(Console.ReadLine());



for (int i = 0; i < broiKomandi; i++)
{
    string[] komandi = Console.ReadLine().Split(" ").ToArray();
    bmw.driveCar(double.Parse(komandi[2]), komandi);
    kamion.driveTruck(double.Parse(komandi[2]), komandi);

}


Console.WriteLine("Car: " + Math.Round(bmw.Fuel, 2));
Console.WriteLine("Truck: " + Math.Round(kamion.Fuel, 2));