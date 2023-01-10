namespace ChainOfResponsibility
{
    public interface IWorker
    {
        IWorker setNextWorker(IWorker worker);

        string Execute(string command);
    }
}