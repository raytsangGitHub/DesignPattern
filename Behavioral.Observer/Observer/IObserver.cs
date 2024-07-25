namespace Behavioral.Observer
{
    public interface IObserver
    {
        //The Observer defines an updating interface for objects that should be notified of changes in a Subject.
        void update(string availability);
    }
}
