using System;

namespace TemplateMethod
{
    public abstract class Transmitter
    {
        protected virtual void VoiceRecord()
        {
            Console.WriteLine("Запись фрагмента речи");
        }
        // дискритизация
        protected virtual void Simpling(){}
        // отцифровка
        protected virtual void Digitization(){}
        // модуляция
        protected virtual void Modulation(){}

        protected virtual void Transmision()
        {
            Console.WriteLine("Передача сигнала по каналу");
        }

        public void ProcessStart()
        {
            VoiceRecord();
            Simpling();
            Digitization();
            Modulation();
            Transmision();
        }

    }
}