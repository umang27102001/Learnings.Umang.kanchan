using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.Logger
{
    internal class Logger
    {
        private readonly ILoggerSave _save;
        public Logger(ILoggerSave save)
        {
            _save = save;
        }
        public void SaveLog(string message)
        {
            _save.Save(message);
        }
    }
}
