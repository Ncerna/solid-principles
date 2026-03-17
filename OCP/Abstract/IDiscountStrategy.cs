using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Abstract
{
    public interface IDiscountStrategy
    {
        decimal Calculate(decimal price); // Contract: every discount type must implement this
    }
}
