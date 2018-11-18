using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    abstract class DishBuilder
    {
        public Dish Dish { get; private set; }

        public void CreateDish()
        {
            Dish = new Dish();
        }

        public abstract void SetDishName();

        public abstract void SetBasicIngradient();

        public abstract void SetAdditionalingradient();

        public abstract void SetSpice();
    }
}
