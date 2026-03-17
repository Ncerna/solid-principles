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
