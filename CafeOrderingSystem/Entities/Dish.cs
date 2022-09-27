using System;
using System.Collections.Generic;

namespace CafeOrderingSystem.Entities
{
    public class Dish
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Ingredient> Ingredients { get; set; }
        public decimal Price { get; set; }
        public int EstimatedCookingTime { get; set; }
    }
}
