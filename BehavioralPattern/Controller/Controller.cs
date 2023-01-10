namespace Controller
{
    public class Controller : IController
    {
        private Designer _designer;
        private Director _director;

        public Controller(Director director, Designer designer)
        {
            _director = director;
            _director.SetController(this);

            _designer = designer;
            _designer.SetController(this);
        }
        
        
        public void Notify(Employee employee, string message)
        {
            if (employee is Director dir)
            {
                if (message == "")
                    _designer.SetWork(false);
                else
                    _designer.SetWork(true);
            }

            if (employee is Designer des)
            {
                if (message == "Дизайнер проектирует")
                    _director.GiveCommand("");
            }
        }
    }
}