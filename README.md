# SOLID Principles Examples in C#

This repository contains **examples of all 5 SOLID principles** implemented in C#.  
Each principle is explained conceptually, the problem it solves, when to use it, and includes the exact code examples from this project.

---

## 1️⃣ Single Responsibility Principle (SRP)

**Definition:**  
A class should have only one reason to change.  

**Problem it solves:**  
- Avoids classes doing multiple unrelated tasks  
- Improves maintainability and testability  

**When to use:**  
- When a class is handling more than one responsibility  

**Example:**

```csharp
// SRP: Each class has one responsibility
public class PaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment: {amount}");
    }
}

public class ShippingService
{
    public void ShipOrder(string address)
    {
        Console.WriteLine($"Shipping order to {address}");
    }
}

public class InvoiceService
{
    public void SendInvoice(string email)
    {
        Console.WriteLine($"Sending invoice to {email}");
    }
}
Open/Closed Principle (OCP)

Definition:
Software entities (classes, modules, functions) should be open for extension, but closed for modification.

Problem it solves:

Prevents modifying existing classes when adding new functionality

Reduces risk of introducing bugs in working code

Makes the system easier to maintain and extend

When to use:

When you want to add new behavior without changing existing classes

When the system is expected to grow with new requirements

Example:

// OCP: DiscountService is closed for modification but open for extension
public interface IDiscountStrategy
{
    decimal Calculate(decimal price);
}

// Concrete discount implementations
public class VipDiscount : IDiscountStrategy
{
    public decimal Calculate(decimal price)
    {
        return price * 0.8m; // 20% discount
    }
}

public class RegularDiscount : IDiscountStrategy
{
    public decimal Calculate(decimal price)
    {
        return price * 0.95m; // 5% discount
    }
}

// DiscountService does not change when adding new discounts
public class DiscountService
{
    public decimal CalculateDiscount(IDiscountStrategy strategy, decimal price)
    {
        return strategy.Calculate(price);
    }
}

// Usage example
var discountService = new DiscountService();

var vipPrice = discountService.CalculateDiscount(new VipDiscount(), 100m);
Console.WriteLine($"VIP Discount Price: {vipPrice}");

var regularPrice = discountService.CalculateDiscount(new RegularDiscount(), 100m);
Console.WriteLine($"Regular Discount Price: {regularPrice}");

Explanation:

DiscountService does not need to be modified when a new discount type is added.

New discount behavior is added by creating classes that implement IDiscountStrategy.

This keeps the system flexible and safe, following OCP.
