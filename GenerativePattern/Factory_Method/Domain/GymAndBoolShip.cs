namespace Factory_Method.Properties.Domain
{
    public class GymAndBoolShip : IMemberShip
    {
        private string _name;
        private string _description;
        private decimal _price;
        private const double _extraProcentToPrice = 1.2;

        public GymAndBoolShip(string name, decimal price)
        {
            _price = price * (decimal)_extraProcentToPrice;
            _name = name;
        }
        
        public string Name { get; }
        public string Description { get; }
        
        public decimal GetPrice()
        {
            return _price;
        }

        public string NewDescription(string description)
        {
            return _description = description;
        }
    }
}