using System;

namespace Iterator
{
    internal class Program
    {
        // последовательно обходить элементы составных объектов, не раскрывая их внутреннего представления
        // коллекция даже не будет знать что итератор обходит ее
        // но при этом сама коллекция может создавать итераторы, так как она знает, какие именно итераторы могут с ней работать.
        public static void Main(string[] args)
        {
            DataStack dataStack1 = new DataStack();
            for (int i = 0; i < 5; i++)
            {
                dataStack1.Push(i);
            }

            DataStack dataStack2 = new DataStack(dataStack1);

            Console.WriteLine(dataStack1 == dataStack2); 
            
            dataStack2.Push(10);

            Console.WriteLine(dataStack1 == dataStack2);
            Console.WriteLine(dataStack1 != dataStack2);
        }
    }
}