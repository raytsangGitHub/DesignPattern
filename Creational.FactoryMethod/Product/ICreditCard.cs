using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
    /// <summary>
    /// Prove of object extendibility (OCP). Add this interface and a CreditBalance class
    /// </summary>
    public interface IExtendCreditCard 
    { 
        int GetCreditBalance();
    }
}
