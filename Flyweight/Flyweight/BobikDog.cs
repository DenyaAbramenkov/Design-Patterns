using System;

namespace Flyweight
{
    class BobikDog : Dog
    {
        public int Speed { get; set; }

        public BobikDog()
        {
            Color = "Orange";
            Speed = 10;
        }

        public override void Run(int speed)
        {
            Console.WriteLine($"{Color} dog run with {Speed} km/h");
        }
    }
}
