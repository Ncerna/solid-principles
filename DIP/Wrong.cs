using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class EmailService
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }

    public class Notification
    {
        private EmailService _emailService = new EmailService(); // ❌ depende de implementación

        public void Notify(string message)
        {
            _emailService.Send(message);
        }
    }
}
