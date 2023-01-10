using System;

namespace Controller
{
    public class Director : Employee
    {
        private string _text;
        
        public Director(IController controller = null) : base(controller)
        {
        }

        public void GiveCommand(string text)
        {
            _text = text;
            if(text == "")
                Console.WriteLine("->Директор знает что работает дизайнер");
            else
                Console.WriteLine("->Директор дал коммануд" + text);
            _controller.Notify(this, text);
        }
    }
}