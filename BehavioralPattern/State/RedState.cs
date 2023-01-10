using System;

namespace State
{
    public class RedState : State
    {
        public override void NextState()
        {
            Console.WriteLine("Красный цвет");
        }

        public override void PreviuosState()
        {
            Console.WriteLine("Из красного в желтый");
            _trafficLight.SetState(new YellowState());
        }
    }
}