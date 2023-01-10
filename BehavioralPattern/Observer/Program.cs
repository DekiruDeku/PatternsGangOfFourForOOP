using System;

namespace Observer
{
    internal class Program
    {
        // паттерн в первую очередь для того чтоб оповещать одни обьекты что случились изменения в определенном обьекте
        // В примере оптовщик и покупатель подписаны на изменения на цены в магазине
        public static void Main(string[] args)
        {
            Product product = new Product(400);
            
            Marketing marketing = new Marketing(product);
            WholeSale wholeSale = new WholeSale(product);
            Customer customer = new Customer(product);
            
            
            product.ChangePrice(320);
            Console.WriteLine("Прошло N колово времени");
            product.ChangePrice(333);
            product.ChangePrice(301);
            marketing.RemoveFromObserver(); //достало оповещение о любой смене цен...
            product.ChangePrice(310);
            product.ChangePrice(280);
        }
    }
}