namespace Behavioral.ChainOfResponsibility.one
{
    public class NegativeProcessor : IChain
    {

        private IChain nextInChain;

        public void setNext(IChain c)
        {
            this.nextInChain = c;
        }
        public void process(Number n)
        {
            int request = n.getNumber(); 
            if (request < 0)
            {
                Console.WriteLine( "NegativeProcessor: " + request);
            }
            else
            {
                nextInChain.process(n);  //pass the request to next chain.
            }
        }

    }
}
