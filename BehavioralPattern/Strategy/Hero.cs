using System;
using Strategy.Strategy;

namespace Strategy
{
    public class Hero
    {
        private string _name;
        private IWeapon? _weapon;

        public Hero(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }

        public IWeapon? Weapon
        {
            get
            {
                return _weapon;
            }
            private set
            {
                _weapon = value;
            }
        } 
        
        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine("________________");

            if (_weapon == null)
            {
                Console.WriteLine("Атака невозможно");
                return;
            }

            Console.WriteLine(_name + " грозно встал");
            Console.WriteLine(_name + " ");
            _weapon.Attack();
            Console.WriteLine(_name + " выдохнул с облегчением");
        }
    }
}