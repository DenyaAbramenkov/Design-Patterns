using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    abstract class Dog
    {
        public string Color;

        public abstract void Run(int speed);
    }
}
