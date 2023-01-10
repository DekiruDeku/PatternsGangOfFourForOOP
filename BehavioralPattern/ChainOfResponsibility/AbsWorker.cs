namespace ChainOfResponsibility
{
    public abstract class AbsWorker : IWorker
    {
        private IWorker _nextworker;

        public AbsWorker()
        {
            _nextworker = null;
        }
        
        public IWorker setNextWorker(IWorker worker)
        {
            return _nextworker = worker;
        }

        public virtual string Execute(string command)
        {
            if (_nextworker != null)
                return _nextworker.Execute(command);
            return string.Empty;
        }
    }
}