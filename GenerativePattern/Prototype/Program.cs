using System;

namespace Prototype
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var doner = new Sheep();
            doner.SetName("Доминик");

            var donerClone = doner.Clone();

            Console.WriteLine(donerClone.GetName());

            Sheep[] doners = new[] { new Sheep(), new Sheep(), new Sheep() };
            // Неочевидный плюс Прототипа в том, что вы можете
            // клонировать набор объектов, не зная их
            // конкретных классов


        }
    }
}