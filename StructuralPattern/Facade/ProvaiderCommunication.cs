using System;

namespace Facade
{
    // Абстракция части какой либо системы
    public class ProvaiderCommunication
    {
        public void Recive()
        {
            Console.WriteLine("Товар получен");
        }

        public void Payman()
        {
            Console.WriteLine("Опалата поставщику");
        }
    }
}