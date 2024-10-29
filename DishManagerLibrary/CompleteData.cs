using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishManagerLibrary
{
    public class CompleteData
    {
        public List<Ingredient> IngredientList { get; private set; }

        public List<Dish> DishList { get; private set; }

        public CompleteData()
        {
            DishList = Dish.DishList.ToList();
            IngredientList = Ingredient.IngredientList.ToList();
        }
    }
}