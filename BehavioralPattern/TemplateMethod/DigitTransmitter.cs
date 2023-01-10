using System;

namespace TemplateMethod
{
    public class DigitTransmitter : Transmitter
    {
        protected override void Digitization()
        {
            Console.WriteLine("Отцифровка");
        }

        protected override void Simpling()
        {
            Console.WriteLine("Дискритизация записаного фрагмента");
        }

        protected override void Modulation()
        {
            Console.WriteLine("Модуляция цифрового сигнала");
        }
    }
}