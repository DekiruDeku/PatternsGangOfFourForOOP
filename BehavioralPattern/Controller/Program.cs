using System;

namespace Controller
{
    internal class Program
    {
        // позволяет уменьшить связанность множества
        // классов между собой, благодаря перемещению этих связей
        // в один класс
        
        // В примере дизайнер - посредник - директор
        public static void Main(string[] args)
        {
            Designer designer = new Designer();
            Director director = new Director();
            Controller controller = new Controller(director, designer);
            
            director.GiveCommand("Проектировать");

            Console.WriteLine();
            
            designer.ExcecuteWork();
        }
    }
}