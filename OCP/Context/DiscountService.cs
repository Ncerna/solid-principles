using OCP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Context
{

    public class DiscountService
    {
        // OCP: This class is CLOSED for modification
        // We don't change this method when new discount types are added

        public decimal CalculateDiscount(IDiscountStrategy strategy, decimal price)
        {
            // OCP: Behavior is EXTENDED via different strategy implementations
            return strategy.Calculate(price);
        }
    }
}
