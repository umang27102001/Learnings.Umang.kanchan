using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.DIP.Logger
{
    public interface IConsoleLogger
    {
        void LogMessage(string message);
    }
}
