namespace Controller
{
    public abstract class Employee
    {
        protected IController _controller;

        public Employee(IController controller)
        {
            _controller = controller;
        }

        public void SetController(IController controller)
        {
            _controller = controller;
        }
    }
}