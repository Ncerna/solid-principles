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
## 2️⃣ Open/Closed Principle (OCP)

**Definition:**  
Software entities should be open for extension, but closed for modification.  

**Problem it solves:**  
- Avoids modifying existing code when adding new functionality  
- Reduces risk of introducing bugs  
- Improves maintainability  

**When to use:**  
- When the system is expected to grow with new behavior  
- When adding features frequently  

**Example:**

```csharp
// OCP: DiscountService is closed for modification but open for extension
public interface IDiscountStrategy
{
    decimal Calculate(decimal price);
}

public class VipDiscount : IDiscountStrategy
{
    public decimal Calculate(decimal price)
    {
        return price * 0.8m;
    }
}

public class RegularDiscount : IDiscountStrategy
{
    public decimal Calculate(decimal price)
    {
        return price * 0.95m;
    }
}

public class StudentDiscount : IDiscountStrategy
{
    public decimal Calculate(decimal price)
    {
        return price * 0.9m;
    }
}

public class DiscountService
{
    // OCP: Behavior is extended via strategies
    public decimal CalculateDiscount(IDiscountStrategy strategy, decimal price)
    {
        return strategy.Calculate(price);
    }
}


