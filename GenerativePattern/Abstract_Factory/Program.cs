using System;
using Abstract_Factory.Auto;
using Abstract_Factory.Factory;

namespace Abstract_Factory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var newFactoryOfFord = new FactoryOfFord();
            var newFactoryOfBmv = new FactoryOfBMV();
            ILightAuto newCarLight = null;
            IHouseAuto newHouseCar = null;
            
            Console.WriteLine("Hello, Mate! With one car u prefer:\n" +
                              "1.BMV\n" +
                              "2.Ford\n");
            
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("You prefer a:\n" +
                                      "1.Light Auto\n" +
                                      "2.House Auto\n");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1: 
                            newCarLight = newFactoryOfBmv.CreateALightAuto();
                            break; 
                        case 2:
                            newHouseCar = newFactoryOfBmv.CreateAHouseAuto();
                            break;
                        default:
                            Console.WriteLine("Try again");
                            break;
                    }
                    break;
                
                case 2:
                    Console.WriteLine("You prefer a:\n" +
                                      "1.Light Auto\n" +
                                      "2.House Auto\n");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1: 
                            newCarLight = newFactoryOfFord.CreateALightAuto();
                            break; 
                        case 2:
                            newHouseCar = newFactoryOfFord.CreateAHouseAuto();
                            break;
                        default:
                            Console.WriteLine("Try again");
                            break;
                    }

                    break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }

            Console.Write("Specify How many rides: ");
            int howMuch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("How many passengers do you have: ");
            int howPeople = Convert.ToInt32(Console.ReadLine());

            if (newCarLight == null)
                newHouseCar.GoToThePlace(howMuch);
            else
                newCarLight.GoToHePlace(howMuch);

            if (newHouseCar != null)
                newHouseCar.TakeAsleepPlace(howPeople);




        }

}
}
