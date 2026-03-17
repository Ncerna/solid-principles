using LSP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Implementation
{
    public class PayPalPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            // Real implementation would call PayPal API
            Console.WriteLine($"Paid {amount} with PayPal");
        }
    }
}
