using Strategy.Strategy;

namespace Strategy
{
    internal class Program
    {
        // Определение семейство схожих алгоритмов - инкапсулирование каждого из них и обеспечение их взаимозаменяемости
        public static void Main(string[] args)
        {
            Hero hero = new Hero("Повышев");
            
            hero.Attack();
            
            hero.SetWeapon(new WaterGun());
            hero.Attack();
            
            hero.SetWeapon(new Broom());
            hero.Attack();
            
            hero.SetWeapon(new Plunger());
            hero.Attack();
        }
    }
}