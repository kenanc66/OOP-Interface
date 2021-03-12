using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing credit calculated");
        }
    }
}
