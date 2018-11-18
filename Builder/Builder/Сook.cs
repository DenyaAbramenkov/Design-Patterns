using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Сook
    {
        public Dish CookDish(DishBuilder dishBuilder)
        {
            dishBuilder.CreateDish();

            dishBuilder.SetDishName();

            dishBuilder.SetBasicIngradient();

            dishBuilder.SetAdditionalingradient();

            dishBuilder.SetSpice();

            return dishBuilder.Dish;
        }
    }
}
