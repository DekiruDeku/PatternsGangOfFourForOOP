using System;

namespace Decorator
{
    public class HammingCoder : Shell
    {
        public HammingCoder(IProcesor procesor) : base(procesor)
        {
        }

        public override void Process()
        {
            Console.WriteLine("Наложен помехоустойчиый код Хамминга");
            _procesor.Process();
        }
    }
}