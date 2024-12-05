using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.Logger
{
    internal class SaveToDB : ILoggerSave
    {
        public void Save(string message)
        {
            Console.WriteLine($"Logged to {message}");
        }
    }
}
