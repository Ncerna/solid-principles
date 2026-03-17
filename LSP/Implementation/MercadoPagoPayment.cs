using LSP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Implementation
{
    public class MercadoPagoPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            // Real implementation would call MercadoPago API
            Console.WriteLine($"Paid {amount} with MercadoPago");
        }
    }
}
