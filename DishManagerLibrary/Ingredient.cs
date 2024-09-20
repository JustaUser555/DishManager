using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishManagerLibrary
{
    public class Ingredient
    {
        public static List<Ingredient> IngredientList { get; } = new List<Ingredient>();
        public string Name { get; set; }
        public Ingredient(string name)
        {
            Name = name;
            IngredientList.Add(this);
            IngredientList.Sort((x, y) => String.Compare(x.Name, y.Name));
        }

        public static bool RemoveIngredient(Ingredient ingredient)
        {
            if (ingredient != null && IngredientList.Contains(ingredient))
            {
                IngredientList.Remove(ingredient);
                return true;
            }
            return false;
        }
    }
}
