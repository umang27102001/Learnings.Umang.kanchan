using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.DIP.Logger
{
    public class ConsoleLogger:IConsoleLogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
