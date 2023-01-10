using System;

namespace Observer
{
    public class Marketing : IObserver
    {
        private IObserverable _product;

        public Marketing(IObserverable product)
        {
            _product = product;
            _product.AddObserver(this);
        }
        
        public void Update(decimal price)
        {
            Console.WriteLine("Цена продукта поменялась: " + price);
        }

        public void RemoveFromObserver()
        {
            _product.RemoveObserver(this);
        }
    }
}