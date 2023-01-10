using System;

namespace Facade
{
    internal class Program
    {
        // Проблема: нужно представить простой или урезанный интерфейс к сложной подсистеме
        // По факту говоря уже реализовывали фасад в IsuService
        public static void Main(string[] args)
        {
            //приминяем паттерн

            var marketPlace = new MarketPlace();
            
            marketPlace.ProductReceipt();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            marketPlace.ProductRelise();
        }
    }
}