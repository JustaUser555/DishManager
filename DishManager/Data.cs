namespace DishManagerLibrary
{
    public class Dish
    {
        public static List<Dish> AllDishes { get; } = new List<Dish>();
        public string Name { get; set; }
        public string Recipe { get; set; }
        public List<Ingredient> Dependencies { get; set; } = new List<Ingredient>();

        public Dish(string name, string recipe)
        {
            Name = name;
            Recipe = recipe;
            AllDishes.Add(this);
        }
    }

    public class Ingredient
    {
        public static List<Ingredient> AllIngredients { get; } = new List<Ingredient>();
        public string Name { get; set; }

        public Ingredient(string name)
        {
            Name = name;
            AllIngredients.Add(this);
        }
    }

    public static class KitchenManager
    {
        public static void PrintAllDishes()
        {
            foreach (var dish in Dish.AllDishes)
            {
                Console.WriteLine($"{dish.Name}: {dish.Recipe}");
                Console.WriteLine("Ingredients:");
                foreach (var ingredient in dish.Dependencies)
                {
                    Console.WriteLine($"- {ingredient.Name}");
                }
                Console.WriteLine();
            }
        }

        public static void PrintAllIngredients()
        {
            foreach (var ingredient in Ingredient.AllIngredients)
            {
                Console.WriteLine(ingredient.Name);
            }
        }
    }
}
