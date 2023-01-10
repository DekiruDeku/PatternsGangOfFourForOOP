using System;
using System.Linq;
using System.Threading;

namespace Proxy
{
    internal class Program
    {
        // Это пример прокси с кэшироанием и логгированием
        public static void Main(string[] args)
        {
            Chief regularchief = new Chief();
            IChief chief = new ChiefProxy(new Chief()); // вот тут мы и подменяем шефа на прокси шефа

            while (true)
            {
                Thread.Sleep(2000);
                
                Console.Clear();

                Console.WriteLine("Приветвую в приложении");
                Console.WriteLine("============Orders============");
                
                foreach (var orders in chief.GetOrders())
                {
                    string status = chief.GetStatus().First(s => s.Key == orders.Status).Value;
                    Console.WriteLine($"{orders.Name}\t\t {status}");
                }
                
                Console.WriteLine("============regular============"); //для показа разиниц между прокси и обычным
                foreach (var orders in regularchief.GetOrders())
                {
                    string status = chief.GetStatus().First(s => s.Key == orders.Status).Value;
                    Console.WriteLine($"{orders.Name}\t\t {status}");
                }
            }
        }
    }
}