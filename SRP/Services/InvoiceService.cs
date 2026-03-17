using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Services
{
    public class InvoiceService
    {
        public void SendInvoice(string email)
        {
            Console.WriteLine($"Sending invoice to {email}");
        }
    }
}
