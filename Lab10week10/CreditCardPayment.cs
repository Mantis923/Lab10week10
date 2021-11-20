
/// HomeWork 4 (Graded Assignment)    
/// File Name: HomeWork2_Week4_GradedAssignment
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
/// using System;
/// 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  class named Payment is define contains an instance 
/// variable of type double that stores the amount of the payment 
/// and appropriate getter and setter methods. A method is also created
/// named PaymentDetails that outputs an English sentence to describe the amount of the payment.
///  Next, a defined class named CashPayment is derived from Payment.  This class should redefines the PaymentDetails 
///  method to indicate that the payment is in cash.  Included are appropriate constructor(s).The process is repeated 
///  for the class CreditCardPayment redefinining the Payment Details method to include all credit card information in the printout.
///  A Main method is created with  two CashPayment and two CreditCardPayment 
///  objects with different values and calls PaymentDetails for each.
/// </summary>
namespace Lab10week10
{
    public class CreditCardPayment : Payment
    {

        public string Name { get; set; }
        public string CardNumber { get; set; }
        public CreditCardPayment(double amount, string name, string cardNumber) : base(amount)
        {
            Name = name;
            CardNumber = cardNumber;
        }
        public override void PaymentDetails()
        {
            Console.WriteLine(String.Format("The credit card payment amount is" + PaymentAmount.ToString("C")));
            Console.WriteLine($"The name of the credit card {Name}");
            Console.WriteLine($"The number of the credit card is {CardNumber}");
        }



    }
}
