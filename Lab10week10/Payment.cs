using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10week10
{
    public class Payment
    {
        public Payment( double amount)
        {
            PaymentAmount = amount;
        }

        public double PaymentAmount { get; set; }

        public virtual void PaymentDetails()          //saying to subclass that it can be overriden
        {
            Console.WriteLine($"The amount is {PaymentAmount}");
        }
    }

}
