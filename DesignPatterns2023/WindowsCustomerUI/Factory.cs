using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerLibrary;

namespace WindowsCustomerUI
{
    public class Factory
    {
        // this violates OCP, solution is to use factory method
        //*** Remove the "if" conditions by create a list of collection of "ICustomer"
        //In Polymorphism "IF" can be replaced with a dynamic polymorphic collection.
        private List<ICustomer> customers = new();
        public Factory()
        {
            customers.Add(new Customer());  
            customers.Add(new Lead());
        }

        public ICustomer Create(int CustomerType)
        {
            return customers[CustomerType];
        }


        //public ICustomer Create(int CustomerType)
        //{
        //    if (CustomerType == 0)
        //        return new Lead();
        //    else
        //        return new Customer();
        //}
    }
}
