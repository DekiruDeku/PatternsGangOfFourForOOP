using System;

namespace Observer
{
    public class WholeSale : IObserver
    {
        private IObserverable _product;

        public WholeSale(IObserverable product)
        {
            _product = product;
            _product.AddObserver(this);
        }
        
        public void Update(decimal price)
        {
            if (price < 300)
            {
                Console.WriteLine("Оптовик купил товар по цене " + price);
                _product.RemoveObserver(this);
            }
        }
        
        public void RemoveFromObserver()
        {
            _product.RemoveObserver(this);
        }
    }
}