using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    internal class Wrong
    {
    }
    public interface IOrderService
    {
        void ProcessPayment(decimal amount);
        void ShipOrder(string address);
        void SendInvoice(string email);
    }
    public class OnlinePayment : IOrderService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment: {amount}");
        }

        public void ShipOrder(string address)
        {
            throw new NotImplementedException(); // ❌ OnlinePayment cannot ship orders
        }

        public void SendInvoice(string email)
        {
            Console.WriteLine($"Sending invoice to {email}");
        }
    }
}
