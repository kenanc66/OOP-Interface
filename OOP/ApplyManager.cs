using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class ApplyManager
    {
        public void Apply(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }
        public void CreditInform(List<ICreditManager> credits)
        {
            foreach (var loan in credits)
            {
                loan.Calculate();
            }
        }
    }
}
