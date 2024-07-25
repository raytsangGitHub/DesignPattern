using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod
{
    //use abstract class: Create the object without exposing the object creation logic to the client 
    //This is the first part of the definition: create an abstract class for object creation.
    public abstract class CreditCardFactoryBase 
    {
        // *** ICreditCard reture type is the key, which links product and factory.
        // Is aka realization. CreditFactory realize IcreditCard. 
        protected abstract ICreditCard MakeProduct();  //an abstract method. will be implement in the subclasses.


        //This is the factory method -- which create and return the instance of the object.
        public ICreditCard CreateProduct()
        {
            return this.MakeProduct();  //New idea: internally call MakeProduct(). and the this keyword refers to the object that have the definition of the abstract class- MakeProduct().
        }
    }

    //MyProof of concept: prove of abstract class, virtual and abstract class
    public abstract class AbstractProofConcept
    {
        public abstract string Name(string name);

        //proof: client direct access virtual method is ok
        public virtual string GetName(string name)
        {
            return this.Name(name);  //calling the abstract class.
        }
    }


    public class ProofConcept : AbstractProofConcept
    {

        public override string Name(string name)
        {
            return name;
        }
        //polymorphism - same name but difference signature.
        public int Name(int y, int x)
        {
            return x+y;
        }
    }
}
