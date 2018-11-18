using System;

namespace Flyweight
{
    class FlyweightClient
    {
        static void Main(string[] args)
        {
            DogFactory dogFactory = new DogFactory();

            Dog myWhiteDog = dogFactory.GetDog("White");
            myWhiteDog.Run(10);

            Dog myBlackDog = dogFactory.GetDog("Black");
            myBlackDog.Run(7);

            Dog bobik = dogFactory.GetDog("Bobik");
            bobik.Run(5);

            Console.ReadLine();
        }
    }
}
