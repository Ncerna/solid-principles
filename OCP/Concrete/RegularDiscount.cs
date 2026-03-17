using OCP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Concrete
{
    public class RegularDiscount : IDiscountStrategy
    {
        public decimal Calculate(decimal price) => price * 0.1m;
    }
}
