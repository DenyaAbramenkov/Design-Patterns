using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Dish
    {
        public string DishName { get; set; }

        public string BasicIngredient { get; set; }

        public List<string> AdditionalIngredients { get; set; }

        public List<string> Spice { get; set; }

        public override string ToString()
        {
            StringBuilder DishRecipe = new StringBuilder();
            DishRecipe.Append("Name of the dish: " + DishName + Environment.NewLine);
            DishRecipe.Append("Basic ingradient: " + BasicIngredient + Environment.NewLine);
            DishRecipe.Append("AdditionalIngredients: " +Environment.NewLine);
            foreach(string ingr in AdditionalIngredients)
            {
                DishRecipe.Append(ingr + " ");
            }
            DishRecipe.Append(Environment.NewLine);
            DishRecipe.Append("AdditionalIngredients: " + Environment.NewLine);
            foreach (string ingr in Spice)
            {
                DishRecipe.Append(ingr + " ");
            }

            return DishRecipe.ToString();
        }
    }
}
