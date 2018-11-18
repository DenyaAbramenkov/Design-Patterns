using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class ChickenWithMushrooms : DishBuilder
    {
        public override void SetAdditionalingradient()
        {
            Dish.AdditionalIngredients = new List<string>
            {
                "Mushrooms"
            };
        }

        public override void SetBasicIngradient()
        {
            Dish.BasicIngredient = "Chicken";
        }

        public override void SetDishName()
        {
            Dish.DishName = "ChickenWithMushrooms";
        }

        public override void SetSpice()
        {
            Dish.Spice = new List<string>
            {
                "Salt",
                "Pepper"
            };
        }
    }
}
