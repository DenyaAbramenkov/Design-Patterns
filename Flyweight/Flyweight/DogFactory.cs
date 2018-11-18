using System.Collections.Generic;

namespace Flyweight
{
    class DogFactory
    {
        Dictionary<string, Dog> dogs = new Dictionary<string, Dog>();
        public DogFactory()
        {
            dogs.Add("White", new WhiteDog());
            dogs.Add("Black", new BlackDog());
            dogs.Add("Bobik", new BobikDog());
        }

        public Dog GetDog(string key)
        {
            if (dogs.ContainsKey(key))
                return dogs[key];
            else
                return null;
        }
    }
}
