# SOLID Principles: Correct Implementations in .NET 10 & EF Core

This repository demonstrates the **correct implementation of all 5 SOLID principles** using modern **.NET 10 and Entity Framework Core**.  
Each principle is explained clearly, including the problem it solves, when to apply it, and **real code examples from this project**.
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



---

## 2️⃣ Open/Closed Principle (OCP)

```markdown
## 2️⃣ Open/Closed Principle (OCP)

**Definition:**  
Software entities should be open for extension, but closed for modification.  

**Problem it solves:**  
- Avoids modifying existing code when adding new functionality  
- Reduces risk of introducing bugs  
- Improves maintainability  

**Example:**

```csharp
// OCP: DiscountService is closed for modification but open for extension
public interface IDiscountStrategy
{
    decimal Calculate(decimal price);
}

public class VipDiscount : IDiscountStrategy
{
    public decimal Calculate(decimal price) => price * 0.8m;
}

public class RegularDiscount : IDiscountStrategy
{
    public decimal Calculate(decimal price) => price * 0.95m;
}

public class StudentDiscount : IDiscountStrategy
{
    public decimal Calculate(decimal price) => price * 0.9m;
}

public class DiscountService
{
    public decimal CalculateDiscount(IDiscountStrategy strategy, decimal price)
    {
        return strategy.Calculate(price);
    }
}


---

## 3️⃣ Liskov Substitution Principle (LSP)

```markdown
## 3️⃣ Liskov Substitution Principle (LSP)

**Definition:**  
Subtypes must be substitutable for their base types without breaking the system.  

**Problem it solves:**  
- Prevents derived classes from breaking base class expectations  
- Ensures predictable behavior when using polymorphism  

**Example:**

```csharp
// LSP: Any IPayment can replace another without breaking the system
public interface IPayment
{
    void Pay(decimal amount);
}

public class CreditCardPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} with Credit Card");
    }
}

public class PayPalPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} with PayPal");
    }
}

public class FreeOrder
{
    public void Complete()
    {
        Console.WriteLine("Order completed without payment");
    }
}

// Usage
IPayment payment = new CreditCardPayment();
payment.Pay(100m);

payment = new PayPalPayment();
payment.Pay(150m);

FreeOrder freeOrder = new FreeOrder();
freeOrder.Complete();


---

## 4️⃣ Dependency Inversion Principle (DIP)

```markdown
## 4️⃣ Dependency Inversion Principle (DIP)

**Definition:**  
High-level modules should depend on abstractions, not concrete implementations.  

**Problem it solves:**  
- Reduces coupling between modules  
- Makes the system flexible and testable  
- Allows swapping implementations without modifying high-level modules  

**Example:**

```csharp
// DIP: Notification depends on abstraction IMessageService
public interface IMessageService
{
    void Send(string message);
}

public class EmailService : IMessageService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}

public class SmsService : IMessageService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}

// High-level module
public class Notification
{
    private readonly IMessageService _messageService;

    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify(string message)
    {
        _messageService.Send(message);
    }
}

---

## 5️⃣ Interface Segregation Principle (ISP)

```markdown
## 5️⃣ Interface Segregation Principle (ISP)

**Definition:**  
Clients should not be forced to depend on interfaces they do not use.  

**Problem it solves:**  
- Prevents “fat” interfaces  
- Avoids classes implementing methods they don’t need  
- Improves modularity  

**Example:**

```csharp
// ISP: Split interfaces
public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public interface IShippingService
{
    void ShipOrder(string address);
}

public interface IInvoiceService
{
    void SendInvoice(string email);
}

public class OnlinePayment : IPaymentProcessor, IInvoiceService
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment: {amount}");
    }

    public void SendInvoice(string email)
    {
        Console.WriteLine($"Sending invoice to {email}");
    }
}

public class PhysicalShipping : IShippingService
{
    public void ShipOrder(string address)
    {
        Console.WriteLine($"Shipping to {address}");
    }
}





