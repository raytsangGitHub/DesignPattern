using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.WithoutFactoryDP
{
    public class CreditCardFactoryMehtod
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard cardDetails = null!;

            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }

            return cardDetails;  //object created and returned.  But it violates open/close principle, if we want to add other credit card, it would have to modify this code by add an extra option (if else). The Factory method pattern will address this issue.  
        }
    }

    //fixing the OCP violation for the above factory method
    // 1. Create some creator classes in the creator folder
    // 2. Make a abstract creator 
    // below moved to seperate file  --RefactorCreditCardFactoryMethod.cs
    //public abstract class RefactorCreditCardFactoryMethod
    //{

    //}
}
