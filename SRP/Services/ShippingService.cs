using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Services
{
    public class ShippingService
    {
        public void ShipOrder(string address)
        {
            Console.WriteLine($"Shipping order to {address}");
        }
    }
}
