using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.SimpleFactory
{
    //a single factory create single product.
    // 
    internal class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard cardDetails = null!;  //the factory compose ICreditCard, also known as LS principle

            // Depends on the cardType from the caller. But these approach have few "if-else" conditions, what if we want to add another credit card type? the class will have to make modification. which violates OC principle.  solution is to factory method pattern.
            //Problem: the CreditCardFactory is also tightly coupled with the Product classes. Violated DIP and OCP.
            //The fix is use Factory method. 

            if (cardType == "MoneyBack")   
            {
                cardDetails = new MoneyBack(); //tightly coupled with MoneyBack object.
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            return cardDetails;
        }
    }
}
