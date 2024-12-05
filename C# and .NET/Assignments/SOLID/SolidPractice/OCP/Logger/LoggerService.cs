using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.Logger
{
    internal class LoggerService
    {
        private readonly ILoggerSave _save;
        public LoggerService(ILoggerSave save)
        {
            _save = save;
        }
        public void SaveLog(string message)
        {
            _save.Save(message);
        }
    }
}
