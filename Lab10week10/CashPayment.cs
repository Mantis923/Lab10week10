using System;

namespace Lab10week10
{
    public class CashPayment : Payment
    {
        public CashPayment(double amount) : base(amount) { }
        public override void PaymentDetails()
        {
            Console.WriteLine($"The Cash payment amount is {PaymentAmount}");
        }


    }
}
