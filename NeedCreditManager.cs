using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class NeedCreditManager : ICreditManager
    {
        public void Calculate()
        { 
            Console.WriteLine("Need credit calculated");
        }
    }
}
