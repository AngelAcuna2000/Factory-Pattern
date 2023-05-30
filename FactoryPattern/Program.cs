using System;
using System.Data.SqlTypes;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does the vehicle you want to create have?");
            string vehicleType = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(vehicleType);
            vehicle.Drive();
        }
    }
}
