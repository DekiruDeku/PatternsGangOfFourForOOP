using System;
using System.Collections.Generic;

namespace Proxy
{
    // допустим было задание закэшировать и залогировать
    public class ChiefProxy : IChief
    {
        private Chief _chief;
        private IDictionary<int, string>? _statueses; // словарик для кэширования

        public ChiefProxy(Chief chief)
        {
            _chief = chief;
        }
        
        public IDictionary<int, string> GetStatus() //допустим нужно за кэшировать
        {   
            Console.WriteLine($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] GetOrders()\n"); //логирование
            if (_statueses == null)
            {
                _statueses = _chief.GetStatus();
            }

            return _statueses;
        }

        public IEnumerable<Order> GetOrders()
        {
            Console.WriteLine($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] GetOrders()\n"); //логирование
            return _chief.GetOrders();
        }
    }
}