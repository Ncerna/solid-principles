using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    internal class Wrong
    {
    }
    public class DiscountService
    {
        public decimal CalculateDiscount(string customerType, decimal price)
        {
            if (customerType == "VIP")
            {
                return price * 0.8m; // 20% discount
            }
            else if (customerType == "Regular")
            {
                return price * 0.95m; // 5% discount
            }
            else if (customerType == "Student")
            {
                return price * 0.9m; // 10% discount
            }
            else
            {
                return price; // no discount
            }
        }
    }
//    var discountService = new DiscountService();

//Console.WriteLine(discountService.CalculateDiscount("VIP", 100m));      // 80
//Console.WriteLine(discountService.CalculateDiscount("Regular", 100m));  // 95
//Console.WriteLine(discountService.CalculateDiscount("Student", 100m));  // 90
}
