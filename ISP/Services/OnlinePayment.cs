using ISP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Services
{
    // Solo pago
    public class OnlinePayment : IPaymentProcessor, IInvoiceService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment: {amount}");
        }

        public void SendInvoice(string email)
        {
            Console.WriteLine($"Sending invoice to {email}");
        }
    }
}
