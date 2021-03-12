using System;
using System.Collections.Generic;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager need = new NeedCreditManager();
            
            ICreditManager vehicle = new VehicleCreditManager();
            
            ICreditManager house = new HousingCreditManager();

            ILoggerService dataBase = new DataBaseLoggerService();
            ILoggerService file = new FileLoggerService();
            ApplyManager apply = new ApplyManager();
            apply.Apply(need,file);

            List<ICreditManager> credits =
                new List<ICreditManager>() {need, house};
            //apply.CreditInform(credits);
        }
    }
}
