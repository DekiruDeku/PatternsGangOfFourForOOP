namespace Observer
{
    public interface IObserver
    {
        void Update(decimal price);

        void RemoveFromObserver();
    }
}