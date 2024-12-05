﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.NotificationSender
{
    internal class EmailSender : INotificationChannel
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sent through Email {message}");
        }
    }
}