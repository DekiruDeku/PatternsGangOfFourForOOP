namespace Memento
{
    public class ExchangeMemento : IMemento
    {
        private decimal _dollars;
        private decimal _euros;

        public ExchangeMemento(decimal dollars, decimal euros)
        {
            _dollars = dollars;
            _euros = euros;
        }
        
        public decimal GetDollars()
        {
            return _dollars;
        }

        public decimal GetEuros()
        {
            return _euros;
        }
    }
}