using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Abstract
{
    // Define the abstraction (contract) for all payments
    public interface IPayment
    {
        void Pay(decimal amount); // Every payment must implement this method
    }
}
