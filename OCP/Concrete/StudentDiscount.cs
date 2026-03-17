using OCP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Concrete
{
    // ✅ NUEVO TIPO sin tocar DiscountService
    public class StudentDiscount : IDiscountStrategy
    {
        public decimal Calculate(decimal price) => price * 0.15m;
    }
}
