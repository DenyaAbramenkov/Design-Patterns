using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class WhiteDog : Dog
    {
        public WhiteDog()
        {
            Color = "White";
        }

        public override void Run(int speed)
        {
            Console.WriteLine($"{Color} dog run with {speed} km/h");
        }
    }
}
