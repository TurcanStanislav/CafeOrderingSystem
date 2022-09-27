using Business.Domain.Dishes.Repository;
using System.Collections.Generic;
using DishEntity = Business.Domain.Dishes.Dish;
using IngredientEntity = Business.Domain.Ingredients.Ingredient;

namespace Business.Repository.Dish
{
    public class DishRepository : IDishRepository
    {
        const double Profit = 1.2;

        public IEnumerable<DishEntity> GetAll()
        {
            var dishes = new List<DishEntity>
            {
                new DishEntity {
                    Name = "Turkey salad",
                    Description = "This turkey salad is a blend of turkey meat, celery, onions, and sweet red bell pepper mixed with flavors that create an appetizer everyone will love.",
                    Ingredients = new List<IngredientEntity> {
                        new IngredientEntity { Name = "Turkey meat", Price = 10 },
                        new IngredientEntity { Name = "Celery", Price = 11 },
                        new IngredientEntity { Name = "Onion", Price = 12 },
                        new IngredientEntity { Name = "Sweet red bell pepper", Price = 13 }
                    },
                    EstimatedCookingTime = 25,
                },
                new DishEntity {
                    Name = "Vitamin salad",
                    Description = "Fresh and colorful Raw Vitamin Salad! An extremely healthy and flavorful mix of raw beet, carrot, radish, kohlrabi, and sweet corn.",
                    Ingredients = new List<IngredientEntity> {
                        new IngredientEntity { Name = "Raw beet", Price = 10 },
                        new IngredientEntity { Name = "Carrot", Price = 11 },
                        new IngredientEntity { Name = "Radish", Price = 12 },
                        new IngredientEntity { Name = "Kohlrabi", Price = 13 },
                        new IngredientEntity { Name = "Sweet corn", Price = 14 }
                    },
                    EstimatedCookingTime = 15,
                },
                new DishEntity {
                    Name = "Kostitsa pork",
                    Description = "Pork steak is a cut of pork taken from the pork shoulder.",
                    Ingredients = new List<IngredientEntity> {
                        new IngredientEntity { Name = "Pork somership", Price = 22 },
                        new IngredientEntity { Name = "Baked potatoes", Price = 15 },
                        new IngredientEntity { Name = "Sauerkraut", Price = 14 },
                        new IngredientEntity { Name = "Spices", Price = 15 },
                        new IngredientEntity { Name = "Adjika", Price = 16 }
                    },
                    EstimatedCookingTime = 35,
                }
            };

            foreach (var dish in dishes)
            {
                decimal costs = 0;
                foreach (var ingredient in dish.Ingredients)
                    costs += ingredient.Price;

                var price = costs * (decimal)Profit;
                dish.Price = price;
            }

            return dishes;
        }
    }
}
