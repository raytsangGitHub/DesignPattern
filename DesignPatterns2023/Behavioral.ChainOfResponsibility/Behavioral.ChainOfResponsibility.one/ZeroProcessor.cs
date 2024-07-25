
namespace Behavioral.ChainOfResponsibility.one
{
    /// <summary>
    /// ConcreteHandler
    /// </summary>
    public class ZeroProcessor : IChain
    {
        private IChain _nextInChain;
    public void setNext(IChain c)
    {
        this._nextInChain = c;
    }
    public void process(Number n)
    {
        if (n.getNumber() == 0)
        {
                Console.WriteLine("ZeroProcessor : " + n.getNumber());
        }
        else
        {
            _nextInChain.process(n);
        }
    }
}
}
