
// Usage example: simulate real payment flows
using LSP.Abstract;
using LSP.Aplication;
using LSP.Implementation;

var orderService = new OrderPayment();

// Credit card payment
IPayment creditCardPayment = new CreditCardPayment();
orderService.ProcessOrder(creditCardPayment, 100m); // ✅ Works with any IPayment

// PayPal payment
IPayment paypalPayment = new PayPalPayment();
orderService.ProcessOrder(paypalPayment, 200m); // ✅ Works with any IPayment

// MercadoPago payment
IPayment mercadoPagoPayment = new MercadoPagoPayment();
orderService.ProcessOrder(mercadoPagoPayment, 150m); // ✅ Works with any IPayment

// Free order (no money involved, separate flow)
var freeOrder = new FreeOrder();
freeOrder.Complete(); // ✅ No IPayment needed, avoids breaking LSP
