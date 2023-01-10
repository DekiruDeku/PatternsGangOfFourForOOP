using System;

namespace Decorator
{
    public class Transmitter : IProcesor
    {
        private string _data;

        public Transmitter(string data)
        {
            _data = data;
        }
        
        public void Process()
        {
            Console.WriteLine("Данные " + _data + " переданы по каналу");
        }
    }
}