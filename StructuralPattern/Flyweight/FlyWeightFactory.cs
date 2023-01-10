using System;
using System.Collections;
using System.Collections.Generic;

namespace Flyweight
{
    public class FlyWeightFactory
    {
        private Hashtable _flyweight; //хранит список общих данных

        public FlyWeightFactory(List<Shared> shareds)
        {
            _flyweight = new Hashtable();
            foreach (var share in shareds)
            {
              _flyweight.Add(GetKey(share), new Flyweight(share));
            }
        }

        public Flyweight GetFlyweight(Shared shared)
        {
            string key = GetKey(shared);
            if (!_flyweight.Contains(key))
            {
                Console.WriteLine("Фабрка Легковеса: Общий обьект по ключу: " + key + "не найден. Создаем новый");
                _flyweight.Add(key, new Flyweight(shared));
            }
            else
            {
                Console.WriteLine("Фабрика Легковеса: Извлекаем данные по следуюищму ключу " + key);
            }

            return (Flyweight)_flyweight[key];
        }

        public void ListFlyweight()
        {
            int count = _flyweight.Count;
            Console.WriteLine("\n Фабрика легковесов: Всего записей " + count);
            foreach (Flyweight pair in _flyweight.Values)
            {
                Console.WriteLine(pair.GetData());
            }
        }

        private string GetKey(Shared shared)
        {
            return shared.Comapny + "_" + shared.Position;
        }
    }
}