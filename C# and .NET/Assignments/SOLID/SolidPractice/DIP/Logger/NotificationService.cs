using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.DIP.Logger
{
    public class NotificationService
    {
        private IConsoleLogger _logger;
        public NotificationService(IConsoleLogger logger)
        {
            _logger = logger;
        }

        public void Notify(string message)
        {
            _logger.LogMessage(message);
        }
    }
}
