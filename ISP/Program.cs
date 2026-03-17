
using ISP.Abstract;
using ISP.Services;

IPaymentProcessor payment = new OnlinePayment();
payment.ProcessPayment(100m); // ✅ Payment only

IInvoiceService invoice = new OnlinePayment();
invoice.SendInvoice("customer@example.com"); // ✅ Invoice only

IShippingService shipping = new ShippingService();
shipping.ShipOrder("123 Main St"); // ✅ Shipping only