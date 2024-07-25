namespace Creational.FactoryMethod
{
    /// <summary>
    /// This class instantiate and return the MoneyBack object
    /// </summary>
    public class MoneyBackFactory : CreditCardFactoryBase
    {

        protected override ICreditCard MakeProduct()
        {
            //subclasses decide which class to instantiate.
            
            ICreditCard product = new MoneyBack();  //creates the object  
            return product; // return the object. 
        }
    }
}
