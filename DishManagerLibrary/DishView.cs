namespace DishManagerLibrary
{
    public class DishView
    {
        public static List<DishView> DishList { get; set; } = new List<DishView>();

        public string? Name { get; set; }
        public string? Recipe { get; set; }
        public string? IngredientsAsString { get; set; }

        public DishView()
        {
        }

        public static void InitializeDishList()
        {
            List<Dish> allDishes = Dish.DishList;

            DishList = allDishes.Select(d => new DishView
            {
                Name = d.Name,
                Recipe = d.Recipe,
                IngredientsAsString = string.Join(", ", d.Dependencies?.Select(i => i.Name) ?? Enumerable.Empty<string>())
            }).ToList();
        }
    }
}