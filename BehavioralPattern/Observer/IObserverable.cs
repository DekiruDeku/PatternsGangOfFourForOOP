namespace Observer
{
    public interface IObserverable
    {
        void AddObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void Notify();
    }
}