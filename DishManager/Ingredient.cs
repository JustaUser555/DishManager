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
        }
    }
}
