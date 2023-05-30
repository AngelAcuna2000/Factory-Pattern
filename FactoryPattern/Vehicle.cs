using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Vehicle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Vehicle created!");
        }
    }
}
