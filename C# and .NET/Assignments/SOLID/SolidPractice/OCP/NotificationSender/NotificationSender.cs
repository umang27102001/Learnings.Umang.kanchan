using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.NotificationSender
{
    internal class NotificationSender
    {
        private readonly NotificationSender _sender;
        public NotificationSender(NotificationSender sender)
        {
            _sender = sender;
        }
        public void SendNotification(string message)
        {
            _sender.SendNotification(message);
        }
    }
}
