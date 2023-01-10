using System;

namespace Decorator
{
    public class Encryptor : Shell
    {
        public Encryptor(IProcesor procesor) : base(procesor)
        {
        }

        public override void Process()
        {
            Console.WriteLine("Шифр. данных: ");
            _procesor.Process();
        }
    }
}