using System;
using Factory_Method.Factories;
using Factory_Method.Properties.Domain;

namespace Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in our Gym!");
            Console.WriteLine("What member ship u interest>?" +
                              "1.Only Gym" +
                              "2.Gym and pool" +
                              "3.Gym and pool and traing");
            
            int choose = int.Parse(Console.ReadLine());
            MembershipFactory factory = GetFactory(choose);
            IMemberShip memberShip = factory.GetMemberShip();

            Console.WriteLine("You memberhip create" +
                              $"name - {memberShip.Name}" +
                              $"description - {memberShip.Description}" +
                              $"price - {memberShip.GetPrice()}");
        }

        private static MembershipFactory GetFactory(int choose)
        {
            switch (choose)
            {
                case 1:
                    return new GymMemberShipFactory("base", 100);
                case 2:
                    return new GymAndPoolShipFactory("base+", 100);
                case 3:
                    return new PersonalTrainerhipFactory("Pro+", 100, 10);
                default:
                    Console.WriteLine("Please try again :c");
                    break;
            }

            return null;
        }
    }
}