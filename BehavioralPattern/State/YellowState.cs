using System;

namespace State
{
    public class YellowState : State
    {
        public override void NextState()
        {
            Console.WriteLine("Из желтого в краснй");
            _trafficLight.SetState(new RedState());
        }

        public override void PreviuosState()
        {
            Console.WriteLine("Из желтого в зеленый");
            _trafficLight.SetState(new GreenState());
        }
    }
}