using System;


namespace Lab10week10
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment pm1 = new Payment(200.0);
            pm1.PaymentDetails();

            Payment pm2 = new Payment(400.0);
            pm2.PaymentDetails();

            CashPayment cm1 = new CashPayment(550.0);
            cm1.PaymentDetails();
            
            CashPayment cm2 = new CashPayment(450.0);
            cm2.PaymentDetails();

            CreditCardPayment ccp1 = new CreditCardPayment(10000.00, "Ali Baba", "Visa Gold- 4194 5500 5003 9555");
            ccp1.PaymentDetails();
            
            CreditCardPayment ccp2 = new CreditCardPayment(2000000.00, "Sheik Amir Ali", "Capital One Quicksilver- 5178 5500 5003 9555");
            ccp2.PaymentDetails();

            Console.ReadLine();
        }
    }
}
