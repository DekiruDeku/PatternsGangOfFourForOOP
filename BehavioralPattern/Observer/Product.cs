using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer
{
    public class Product : IObserverable
    {
        private List<IObserver> _observers;
        private decimal _price;

        public Product(decimal price)
        {
            _price = price;
            _observers = new List<IObserver>();
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            private set
            {
                _price = value;
            }
        }

        public void ChangePrice(decimal price)
        {
            _price = price;
            Notify();
        }
        
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers.ToList()) // копия списка необходима для возможности удаления конкретного наблюдателя
                                                          // из оригинального списка в реализации метода Update
            {
                observer.Update(_price);
            }
        }
    }
}