using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    internal class Wrong
    {
    }
    public class Payment
    {
        public virtual void Pay(decimal amount)
        {
            Console.WriteLine("Processing payment...");
        }
    }

    public class CreditCardPayment : Payment
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} with credit card");
        }
    }

    public class FreePayment : Payment
    {
        public override void Pay(decimal amount)
        {
            throw new Exception("Free payment does not process money"); // ❌ rompe LSP
        }
    }
    //uso
    //    Payment payment = new FreePayment();
    //payment.Pay(100); // 💥 rompe todo
}
