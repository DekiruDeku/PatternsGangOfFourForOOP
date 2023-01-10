using Factory_Method.Properties.Domain;

namespace Factory_Method.Factories
{
    public class GymMemberShipFactory : MembershipFactory
    {
        private string _name;
        private decimal _price;

        public GymMemberShipFactory(string name, decimal price)
        {
            _name = name;
            _price = price;
        }


        public override IMemberShip GetMemberShip()
        {
            var gymMembership = new GymMembership(_name, _price);
            gymMembership.NewDescription("");
            return gymMembership;
        }
    }
}