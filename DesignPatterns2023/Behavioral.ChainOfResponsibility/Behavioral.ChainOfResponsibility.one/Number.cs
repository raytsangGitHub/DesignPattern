namespace Behavioral.ChainOfResponsibility.one
{
    /// <summary>
    /// The  request object or the handler
    /// </summary>
    public class Number
    {
        private int _number;
        public Number(int number)
        {
            this._number = number;
        }
        public int getNumber() {
        return _number;
        }
    }
}
