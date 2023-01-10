using System;

namespace Factory_Method.Properties.Domain
{
    public class PersonalTrainerShip : IMemberShip
    {
        private string _name;
        private string _description;
        private decimal _price;
        private int _amountOfTraining;
        private const double _exteraPriceForTraining = 2.5;

        public PersonalTrainerShip(string name, decimal price, int amountOfTraining)
        {
            _price = price * (decimal)_exteraPriceForTraining * (amountOfTraining/10);
            _name = name;
            _amountOfTraining = amountOfTraining;

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

        public void AccomplishedTrain()
        {
            if (_amountOfTraining > 0)
            {
                _amountOfTraining--;
                NewDescription($"You have a {_amountOfTraining} train left");
            }

            if (_amountOfTraining == 0)
                Console.WriteLine("У вас закончились тренировки :C");
        }
    }
}