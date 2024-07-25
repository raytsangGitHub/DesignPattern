namespace Creational.FactoryMethod.Creator
{
    public class PlatinumFactory : CreditCardFactoryBase
    {
        //The Factory method lets a class defer instantiation it uses to subclasses.
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}
