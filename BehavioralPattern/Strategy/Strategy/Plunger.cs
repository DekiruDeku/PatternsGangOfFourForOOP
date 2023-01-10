using System;

namespace Strategy.Strategy
{
    public class Plunger : IWeapon
    {
        public void Attack()
        {
            Console.Write("Атака с помощью вантуза");
        }
    }
}