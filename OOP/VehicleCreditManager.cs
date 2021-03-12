using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle credit calculated");
        }
    }
}
