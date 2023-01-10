using System;
using System.Runtime.InteropServices;

namespace TemplateMethod
{
    public class AnalogTransmitter : Transmitter
    {
        // тк для аналоговых данных не требуется дискритизация и отцифровка
        protected override void Modulation()
        {
            Console.WriteLine("Модуляция аналогового сигнала");
        }
    }
}