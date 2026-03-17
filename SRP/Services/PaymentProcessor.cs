using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Services
{
    public class PaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment: {amount}");
        }
    }
}
