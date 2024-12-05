using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.Logger
{
    internal interface ILoggerSave
    {
        public void Save(string message);
    }
}
