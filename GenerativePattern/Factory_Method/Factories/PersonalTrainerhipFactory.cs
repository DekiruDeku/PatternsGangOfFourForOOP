using Factory_Method.Properties.Domain;

namespace Factory_Method.Factories
{
    public class PersonalTrainerhipFactory : MembershipFactory
    {
        private string _name;
        private decimal _price;
        private int _amountTrain;

        public PersonalTrainerhipFactory(string name, decimal price, int amountTrain)
        {
            _name = name;
            _price = price;
            _amountTrain = amountTrain;
        }
        
        public override IMemberShip GetMemberShip()
        {
            var personalTrain = new PersonalTrainerShip(_name, _price, _amountTrain);
            personalTrain.NewDescription($"You have a {_amountTrain} train left");
            return personalTrain;
        }
    }
}