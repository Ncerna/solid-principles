using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Abstract
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

}
