﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DishManagerLibrary
{
    public class Dish
    {
        public static List<Dish> DishList { get; } = new List<Dish>();

        public string Name { get; private set; }
 
        public string? Recipe { get; set; }
        public List<Ingredient>? Dependencies { get; private set; } = new List<Ingredient>();

        public Dish(string name, string? recipe, List<Ingredient>? dependencies)
        {
            if (DishList.Any(dish => String.Compare(dish.Name, name) == 0))
            {
                throw new InvalidOperationException($"A dish with the name '{name}' alredy exists.");
            }
            Name = name;
            Recipe = recipe;
            Dependencies = dependencies;
            if (Dependencies != null)
            {
                Dependencies.Sort((x, y) => String.Compare(x.Name, y.Name));
            }
            DishList.Add(this);
            DishList.Sort((x, y) => String.Compare(x.Name, y.Name));
        }

        public static bool RemoveDish(Dish dish)
        {
            if (dish != null && DishList.Contains(dish))
            {
                DishList.Remove(dish);
                return true;
            }
            return false;
        }

        public bool SetName(string newName)
        {
            if(newName == Name)
            {
                return true;
            }
            else if (DishList.Any(dish => String.Compare(newName, dish.Name) == 0))
            {
                return false;
            }
            else
            {
                Name = newName;
                return true;
            }
        }

        public bool SetDependencies(List<Ingredient>? dependencies)
        {
            
            if(dependencies != null)
            {
                List<String> duplicateNames = dependencies.GroupBy(x => x.Name)
                    .Where(x => x.Count() > 1)
                    .Select(x => x.Key)
                    .ToList();

                if(duplicateNames.Count == 0)
                {
                    Dependencies = dependencies.ToList();
                    return true;
                } else
                {
                    return false;
                }
            } else
            {
                Dependencies = null;
                return true;
            }
        }
    }
}
