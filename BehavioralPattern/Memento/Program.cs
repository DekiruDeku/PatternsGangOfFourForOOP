using System;

namespace Memento
{
    internal class Program
    {
        // позволяет делать снимки состояния объектов, не раскрывая подробностей их реализации.
        // в дальнейшем можем восстонавливать состояние обьектов
        
        // по факту просто говорим самому обьекту себя запоминать 
        public static void Main(string[] args)
        {
            Exchange exchange = new Exchange(10, 10);
            Memory memory = new Memory(exchange);
            
            exchange.GetDollars();
            exchange.GetEuros();

            Console.WriteLine("Продали доллар купили евро");
            
            exchange.Sell();
            exchange.Buy();

            exchange.GetDollars();
            exchange.GetEuros();

            Console.WriteLine("Сохранение состояния");
            memory.Backup();

            Console.WriteLine("Еще раз покупаем продаем");
            
            exchange.Sell();
            exchange.Buy();

            exchange.GetDollars();
            exchange.GetEuros();
            
            Console.WriteLine("Возвращаем все как было");
            
            memory.Undo();
            
            exchange.GetDollars();
            exchange.GetEuros();


        }
    }
}