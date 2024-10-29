using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DishManagerLibrary
{
    public class Ingredient
    {
        public static List<Ingredient> IngredientList { get; } = new List<Ingredient>();
        public string Name { get; private set; }
        public Ingredient(string name)
        {
            if (IngredientList.Any(ingredient => String.Compare(ingredient.Name, name) == 0))
            {
                throw new InvalidOperationException($"An ingredient with the name '{name}' alredy exists.");
            }
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

        public bool SetName(string newName)
        {
            if (newName == Name)
            {
                return true;
            }
            else if (IngredientList.Any(ingredient => String.Compare(ingredient.Name, newName) == 0))
            {
                return false;
            }
            else
            {
                Name = newName;
                return true;
            }
        }
    }
}
