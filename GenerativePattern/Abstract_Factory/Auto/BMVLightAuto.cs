using System;

namespace Abstract_Factory.Auto
{
    public class BMVLightAuto : ILightAuto
    {
        private double _speed = 15;
        
        
        public void GoToHePlace(int distance)
        {
            var howMuch = distance / _speed;
            Console.WriteLine("Your be able on path: " + howMuch);
        }
    }
}