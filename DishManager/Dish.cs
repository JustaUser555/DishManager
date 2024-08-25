using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishManagerLibrary
{
    public class Dish
    {
        public static List<Dish> DishList { get; } = new List<Dish>();

        public required string Name { get; set; }
        public string? Recipe { get; set; }
        public List<Ingredient>? Dependencies { get; set; } = new List<Ingredient>();

        public Dish(string name, string? recipe, List<Ingredient>? dependencies)
        {
            Name = name;
            Recipe = recipe;
            Dependencies = dependencies;
            DishList.Add(this);
        }
    }
}
