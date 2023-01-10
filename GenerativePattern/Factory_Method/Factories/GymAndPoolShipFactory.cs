using Factory_Method.Properties.Domain;

namespace Factory_Method.Factories
{
    public class GymAndPoolShipFactory : MembershipFactory
    {
        private string _name;
        private decimal _price;

        public GymAndPoolShipFactory(string name, decimal price)
        {
            _name = name;
            _price = price;
        }
        
        public override IMemberShip GetMemberShip()
        {
            var gymAndPoolMembership = new GymAndBoolShip(_name, _price);
            gymAndPoolMembership.NewDescription("");
            return gymAndPoolMembership;
        }
    }
}