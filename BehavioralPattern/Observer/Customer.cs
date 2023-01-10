using System;

namespace Observer
{
    public class Customer : IObserver
    {
        private IObserverable _product;

        public Customer(IObserverable product)
        {
            _product = product;
            _product.AddObserver(this);
        }
        
        public void Update(decimal price)
        {
            if (price < 350)
            {
                Console.WriteLine("Покупатель купил товар по цене " + price);
                _product.RemoveObserver(this);
            }
        }
        
        public void RemoveFromObserver()
        {
            _product.RemoveObserver(this);
        }
    }
}