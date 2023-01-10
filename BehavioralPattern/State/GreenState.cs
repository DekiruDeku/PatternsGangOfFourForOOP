using System;

namespace State
{
    public class GreenState : State
    {
        public override void NextState()
        {
            Console.WriteLine("Из зеленого в желтый");
            _trafficLight.SetState(new YellowState());
        }

        public override void PreviuosState()
        {
            Console.WriteLine("Зеленый цвет");
        }
    }
}