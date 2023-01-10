using System;

namespace Strategy.Strategy
{
    public class Broom : IWeapon
    {
        public void Attack()
        {
            Console.Write("Атака с помощью веника");
        }
    }
}