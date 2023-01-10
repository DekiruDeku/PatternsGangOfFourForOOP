using System;
using System.Runtime.InteropServices;

namespace Controller
{
    public class Designer : Employee
    {
        private bool _isWorking;


        public Designer(IController controller = null) : base(controller)
        {
        }

        public void ExcecuteWork()
        {
            Console.WriteLine("Дизайнер начал работать");
            _controller.Notify(this,"Дизайнер проектирует");
        }

        public void SetWork(bool state)
        {
            _isWorking = state;
            if (state)
                Console.WriteLine("<-Дизайнер свободен");
            else
                Console.WriteLine("<-Дизайнер пахает");

        }
    }
}