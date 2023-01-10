using System;

namespace Abstract_Factory.Auto
{
    public class FordHouseAuto : IHouseAuto
    {
        private double _speed = 10;
        private int _sleepPlaces = 5;

        public void GoToThePlace(int distance)
        {
            var howMuch = distance / _speed;
            Console.WriteLine("Your be able on path: " + howMuch);
        }

        public void TakeAsleepPlace(int howMuchPeopleInACar)
        {
            if(_sleepPlaces >= howMuchPeopleInACar)
                Console.WriteLine("There's a place for everyone, you have left: " + (_sleepPlaces - howMuchPeopleInACar));
            else
                Console.WriteLine("You don't have enough bedrooms for everyone, you still need: " + (howMuchPeopleInACar - _sleepPlaces));
        }
    }
}