using System;

namespace OOP_3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("logged on file");
        }
    }
}
