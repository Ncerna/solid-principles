using DIP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Implementation
{
    // Implementación 1
    public class EmailService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }
}
