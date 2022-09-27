using CafeOrderingSystem.Entities;
using System.Collections.Generic;

namespace CafeOrderingSystem
{
    public class Launch
    {
        public IList<Cook> Cooks { get; set; }
        public IList<Dish> Dishes { get; set; } 

        const double Profit = 1.2;

        public Launch()
        {
            SetCooksData();
            SetDishesData();
            ShowUI();
        }

        public void ShowUI()
        {
            UserInterface.ShowDishes(Dishes);
            UserInterface.ShowMainMenu();
        }

        public void SetCooksData()
        {
            Cooks = new List<Cook>
            {
                new Cook { Name = "Boris Fooler" },
                new Cook { Name = "Elena Rotaru" },
                new Cook { Name = "Gill Lorance" }
            };
        }

        public void SetDishesData()
        {
            Dishes = new List<Dish>
            {
                new Dish { 
                    Name = "Turkey salad", 
                    Description = "This turkey salad is a blend of turkey meat, celery, onions, and sweet red bell pepper mixed with flavors that create an appetizer everyone will love.",
                    Ingredients = new List<Ingredient> {
                        new Ingredient { Name = "Turkey meat", Price = 10 },
                        new Ingredient { Name = "Celery", Price = 11 },
                        new Ingredient { Name = "Onion", Price = 12 },
                        new Ingredient { Name = "Sweet red bell pepper", Price = 13 }
                    },
                    EstimatedCookingTime = 25,
                },
                new Dish {
                    Name = "Vitamin salad",
                    Description = "Fresh and colorful Raw Vitamin Salad! An extremely healthy and flavorful mix of raw beet, carrot, radish, kohlrabi, and sweet corn.",
                    Ingredients = new List<Ingredient> {
                        new Ingredient { Name = "Raw beet", Price = 10 },
                        new Ingredient { Name = "Carrot", Price = 11 },
                        new Ingredient { Name = "Radish", Price = 12 },
                        new Ingredient { Name = "Kohlrabi", Price = 13 },
                        new Ingredient { Name = "Sweet corn", Price = 14 }
                    },
                    EstimatedCookingTime = 15,
                },
                new Dish {
                    Name = "Kostitsa pork",
                    Description = "Pork steak is a cut of pork taken from the pork shoulder.",
                    Ingredients = new List<Ingredient> {
                        new Ingredient { Name = "Pork somership", Price = 22 },
                        new Ingredient { Name = "Baked potatoes", Price = 15 },
                        new Ingredient { Name = "Sauerkraut", Price = 14 },
                        new Ingredient { Name = "Spices", Price = 15 },
                        new Ingredient { Name = "Adjika", Price = 16 }
                    },
                    EstimatedCookingTime = 35,
                }
            };

            foreach(var dish in Dishes)
            {
                decimal costs = 0;
                foreach(var ingredient in dish.Ingredients)
                    costs += ingredient.Price;

                var price = costs * (decimal)Profit;
                dish.Price = price;
            }
        }
    }
}
