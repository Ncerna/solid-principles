using LSP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Aplication
{
   
    // High-level module that processes orders
    // It depends on the abstraction IPayment, not on concrete classes
    public class OrderPayment
    {
        public void ProcessOrder(IPayment payment, decimal amount)
        {
            // LSP: any IPayment can be substituted here without breaking the system
            payment.Pay(amount);
        }
    }
}
