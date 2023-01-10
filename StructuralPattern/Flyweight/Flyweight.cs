using System;

namespace Flyweight
{
    public class Flyweight
    {
        private Shared _shared;

        public Flyweight(Shared shared)
        {
            _shared = shared;
        }

        public void Process(Unique unique)
        {
            Console.WriteLine("Отоброжаем данные " + _shared.Comapny + "_" + _shared.Position + "и уникальный id" + unique.Name + "_" + unique.Passport);
        }

        public string GetData()
        {
            return _shared.Comapny + "_" +_shared.Position;
        }
    }
}