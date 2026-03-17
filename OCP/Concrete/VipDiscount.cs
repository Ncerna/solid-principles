using OCP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Concrete
{
    public class VipDiscount : IDiscountStrategy
    {
        public decimal Calculate(decimal price) => price * 0.2m;
    }
}
