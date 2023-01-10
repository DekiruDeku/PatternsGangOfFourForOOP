using System;

namespace Facade
{
    // Абстракция части какой либо системы
    public class Database
    {
        public void Insert()
        {
            Console.WriteLine("Вставили в базу данных");
        }

        public void Delete()
        {
            Console.WriteLine("Удаление из базы данных");
        }
    }
}