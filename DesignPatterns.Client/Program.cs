
using DesignPatterns.Library.Polymorphism;

var payments = new PaymentBase[] { new CreditCard(100), new Paypal(200) };
foreach (var payment in payments)
    payment.ProcessPayment();