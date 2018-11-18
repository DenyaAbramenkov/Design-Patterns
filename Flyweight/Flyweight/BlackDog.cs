using System;


namespace Flyweight
{
    class BlackDog : Dog
    {
        public BlackDog()
        {
            Color = "Black";
        }

        public override void Run(int speed)
        {
            Console.WriteLine($"{Color} dog run with {speed} km/h");
        }
    }
}
