using LSP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Implementation
{
    public class CreditCardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            // Real implementation would call credit card gateway API
            Console.WriteLine($"Paid {amount} with Credit Card");
        }
    }
}
