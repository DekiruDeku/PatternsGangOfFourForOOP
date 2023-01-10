using System;

namespace Memento
{
    public class Exchange
    {
        private decimal _dollars;
        private decimal _euros;

        public Exchange(decimal dollars, decimal euros)
        {
            _dollars = dollars;
            _euros = euros;
        }

        public void GetDollars()
        {
            Console.WriteLine("Долларов: " + _dollars);
        }

        public void GetEuros()
        {
            Console.WriteLine("Евро: " + _euros);
        }

        public void Sell()
        {
            if (_dollars > 0)
                _dollars--;
        }

        public void Buy()
        {
            ++_euros;
        }

        public ExchangeMemento Save()
        {
            return new ExchangeMemento(_dollars, _euros);
        }

        public void Restore(IMemento exchangeMemento)
        {
            _dollars = exchangeMemento.GetDollars();
            _euros = exchangeMemento.GetEuros();
        }
    }
}