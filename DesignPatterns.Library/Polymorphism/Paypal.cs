using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Polymorphism
{
    public class Paypal
        : PaymentBase
    {
        public Paypal(int amount) 
            : base(amount)
        {
        }

        public override void ProcessPayment()
        {
            var msg = $"PayPal payment: {base.Amount}";
            Console.WriteLine(msg);
        }
    }
}
