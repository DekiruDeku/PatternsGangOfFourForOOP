using System;
using System.Collections.Generic;
using System.Threading;

namespace Proxy
{
    public class Chief : IChief // обьект до прокси должен реализовывать подогнанный для него интерфейс
    {
        public IDictionary<int, string> GetStatus()
        {
            Dictionary<int, string> statues = new Dictionary<int, string>();
            statues.Add(1,"ready");
            statues.Add(2,"not ready");
            statues.Add(3,"in process");

            Thread.Sleep(2000); //эмулируем то что статусы выдаются долго, поэтому делаем задержку 2 секунды
            return statues;
        }

        public IEnumerable<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            
            orders.Add(new Order("Бургер", RandomizeStatus()));
            orders.Add(new Order("Паста", RandomizeStatus()));
            orders.Add(new Order("Картошка", RandomizeStatus()));

            return orders;
        }

        //Эмулируем что они типо готовятся
        private static int RandomizeStatus()
        {
            return new Random().Next(1,4);
        }

    }
}