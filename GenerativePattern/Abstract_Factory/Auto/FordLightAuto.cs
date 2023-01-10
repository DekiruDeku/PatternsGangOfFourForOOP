using System;

namespace Abstract_Factory.Auto
{
    public class FordLightAuto : ILightAuto
    {
        private double _speed = 10;
        
        public void GoToHePlace(int distance)
        {
            var howMuch = distance / _speed;
            Console.WriteLine("Your be able on path: " + howMuch);
        }
    }
}