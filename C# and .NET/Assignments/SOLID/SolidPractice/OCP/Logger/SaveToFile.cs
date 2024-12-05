using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.Logger
{
    internal class SaveToFile : ILoggerSave
    {
        public void Save(string message)
        {
            Console.WriteLine($"Saved to File {message}");
        }
    }
}
