using System;
using System.Collections.Generic;

namespace Flyweight
{
    internal class Program
    {
        // Паттерн для опимизации, позволяет хранить больше обьектов в выделенной области оперативной памяти, за счет
        // того разделения общего состояние обьектов между собой
        // Есть контекст и данные. Данные(внутренний состояние), контекст(Внешние состояние)
        // Таким образом, одни и те же объекты можно будет повторно использовать в различных контекстах. Понаджобится меньше обьектов изза их состояния
        public static void Main(string[] args)
        {
            //Применяем паттерн

            FlyWeightFactory flyWeightFactory = new FlyWeightFactory(new List<Shared>()
            {
                new Shared("Microsoft", "Управляющий"),
                new Shared("Sony", "Пиар Менеджер"),
                new Shared("Google", "Web-программист"),
                new Shared("Google", "Android-программист")


            });
            flyWeightFactory.ListFlyweight();
            
            AddSpecialDataBase(flyWeightFactory,
                "Google",
                "Web-программист",
                "Борис",
                "ASD-123");
            AddSpecialDataBase(flyWeightFactory,
                "Sony",
                "Управляющий",
                "Валентин",
                "123e4asd");
            
            flyWeightFactory.ListFlyweight();
            
            //В примере записей в итоге 5, а не 6 ибо Google web prog уже был и внеслилсь только уникальные данные

        }

        static void AddSpecialDataBase(FlyWeightFactory flyWeightFactory, string company, string position, string name,
            string passport)
        {
            Console.WriteLine();
            Flyweight flyweight = flyWeightFactory.GetFlyweight(new Shared(company, position));
            flyweight.Process(new Unique(name, passport));
        }
    }
}