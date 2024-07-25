namespace Behavioral.ChainOfResponsibility.one
{
    public class PositiveProcessor : IChain
    {
        private IChain nextInChain;
    public void setNext(IChain c)
    {
        nextInChain = c;
    }
    public void process(Number n)
    {
        if (n.getNumber() > 0)
        {
                Console.WriteLine("PositiveProcessor : " + n.getNumber());
        }
        else
        {
            nextInChain.process(n);
        }
    }
}
}
