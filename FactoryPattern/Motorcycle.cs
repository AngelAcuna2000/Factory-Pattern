﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Motorcycle created!");
        }
    }
}
