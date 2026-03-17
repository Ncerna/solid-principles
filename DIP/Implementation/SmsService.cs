using DIP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Implementation
{
    // Implementación 2
    public class SmsService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }
}
