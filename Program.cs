using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Trip walk = new Trip(1500, 65);
            walk.TransportMode = new Walker(1750);
            TimeSpan tripTime = walk.ElapsedTime();
            double energyConsumed = walk.EnergyConsumed();
            Console.WriteLine(walk.ToString());

            Trip shopping = new Trip(4500, 225);
            shopping.TransportMode = new PetrolCar();
            tripTime = shopping.ElapsedTime();
            energyConsumed = shopping.EnergyConsumed();            
            Console.WriteLine(shopping.ToString());
        }
    }
}
