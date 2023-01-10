using System;

namespace Facade
{
    // Абстракция части какой либо системы
    public class Site
    {
        public void Placement()
        {
            Console.WriteLine("Размещение на сайте");
        }

        public void Delete()
        {
            Console.WriteLine("Удаление с сайта");
        }
    }
}