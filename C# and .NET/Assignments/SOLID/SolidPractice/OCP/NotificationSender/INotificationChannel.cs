using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.NotificationSender
{
    internal interface INotificationChannel
    {
        public void SendNotification(string message);
    }
}
