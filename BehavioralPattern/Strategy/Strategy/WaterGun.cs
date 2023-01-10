using System;

namespace Strategy.Strategy
{
    public class WaterGun : IWeapon
    {
        public void Attack()
        {
            Console.Write("Атака с помощью водного пистолета");
        }
    }
}