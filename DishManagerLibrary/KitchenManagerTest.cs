using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishManagerLibrary
{
    public static class KitchenManagerTest
    {
        public static void PrintAllDishes()
        {
            foreach (var dish in Dish.DishList)
            {
                Console.WriteLine($"{dish.Name}: {dish.Recipe}");
                Console.WriteLine("Ingredients:");
                if(dish.Dependencies != null)
                {
                    foreach (var ingredient in dish.Dependencies)
                    {
                        Console.WriteLine($"- {ingredient.Name}");
                    }
                    Console.WriteLine();
                }
                
            }
        }

        public static void PrintAllIngredients()
        {
            foreach (var ingredient in Ingredient.IngredientList)
            {
                Console.WriteLine(ingredient.Name);
            }
        }
    }
}
