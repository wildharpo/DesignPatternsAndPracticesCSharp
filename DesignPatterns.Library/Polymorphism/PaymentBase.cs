using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Polymorphism
{
    public abstract class PaymentBase
    {
        public readonly int Amount;

        protected PaymentBase(int amount)
        {
            Amount = amount;
        }

        public abstract void ProcessPayment();
    }
}
