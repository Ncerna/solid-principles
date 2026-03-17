using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Implementation
{
    // Free order (not a payment, no money involved)
    // Notice it does NOT implement IPayment, because it cannot process money
    public class FreeOrder
    {
        public void Complete()
        {
            Console.WriteLine("Order completed with no payment");
        }
    }
}
