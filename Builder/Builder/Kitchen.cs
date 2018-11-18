using Builder;
using System;

namespace Kitchen
{
    class Kitchen
    {
        static void Main(string[] args)
        {
            Сook John = new Сook();

            DishBuilder chickenWithMushroomsRecipe = new ChickenWithMushrooms();

            Dish chickenWithMushrooms = John.CookDish(chickenWithMushroomsRecipe);

            Console.WriteLine(chickenWithMushrooms.ToString());

            Console.ReadLine();
        }
    }
}
