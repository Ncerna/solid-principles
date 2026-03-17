using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    internal class Wrong
    {
    }
    public class OrderProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment: {amount}");
        }

        public void ShipOrder(string address)
        {
            Console.WriteLine($"Shipping order to {address}");
        }

        public void SendInvoice(string email)
        {
            Console.WriteLine($"Sending invoice to {email}");
        }
    }
}
