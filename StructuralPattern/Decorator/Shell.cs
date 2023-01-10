namespace Decorator
{
    //Декоратор
    public abstract class Shell : IProcesor
    {
        protected IProcesor _procesor;

        public Shell(IProcesor procesor)
        {
            _procesor = procesor;
        }
        
        public virtual void Process()
        {
            _procesor.Process();
        }
    }
}