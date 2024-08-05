using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishManagerLibrary
{
    public class DishView
    {
        public string Name { get; set; }
        public string? Recipe { get; set; }
        public string? IngredientsAsString { get; set; }

        public DishView()
        {
            List<Dish> AllDishes = Dish.DishList;
            AllDishes.Select(d => new DishView
            {
                Name = d.Name,
                Recipe = d.Recipe,
                IngredientsAsString = string.Join(", ", d.Dependencies.Select(i => i.Name))
            }).ToList();
        }
    }
}
