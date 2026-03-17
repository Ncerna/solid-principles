using ISP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Services
{
    // Solo envío físico
    public class ShippingService : IShippingService
    {
        public void ShipOrder(string address)
        {
            Console.WriteLine($"Shipping order to {address}");
        }
    }
}
