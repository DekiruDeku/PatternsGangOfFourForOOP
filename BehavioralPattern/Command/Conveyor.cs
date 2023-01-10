using System;

namespace Command
{
    public class Conveyor
    {
        public void On()
        {
            Console.WriteLine("Конвеер запущен");
        }

        public void Off()
        {
            Console.WriteLine("Конвеер остановлен");
        }

        public void SpeedIncrease()
        {
            Console.WriteLine("Повышена скорость конвеера");
        }

        public void SpeedDincrease()
        {
            Console.WriteLine("Понижена скорость конвеера");
        }
    }
}