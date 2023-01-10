namespace Factory_Method.Properties.Domain
{
    public class GymMembership : IMemberShip
    {
        private string _name;
        private string _description;
        private decimal _price;

        public GymMembership(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public string Name => _name;
        public string Description => _description;

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