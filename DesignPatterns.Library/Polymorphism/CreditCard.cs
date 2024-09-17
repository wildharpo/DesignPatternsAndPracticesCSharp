using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Polymorphism
{
    public class CreditCard
        : PaymentBase
    {
        public CreditCard(int amount) 
            : base(amount)
        {
        }

        public override void ProcessPayment()
        {
            var msg = $"Credit card payment: {base.Amount}";
            Console.WriteLine(msg);
        }
    }
}
