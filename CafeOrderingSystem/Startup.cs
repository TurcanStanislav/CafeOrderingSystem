using System.Collections.Generic;
using System;
using System.Linq;
using Business.Domain.Cooks;
using Business.Domain.Dishes;
using Business.Repository.Cook;
using Business.Repository.Dish;

namespace CafeOrderingSystem
{
    public class Startup
    {
        public IEnumerable<Cook> Cooks { get; set; }
        public IEnumerable<Dish> Dishes { get; set; } 


        public Startup()
        {
            SetCooksData();
            SetDishesData();
            Run();
        }

        public void Run()
        {
            UserInterface.ShowDishes(Dishes);
            while (true)
            {
                UserInterface.ShowMainMenu();
                UserInterface.AskForDish();
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    var dishExists = Dishes.Any(x => x.Name.ToLower() == input.ToLower());
                    if(dishExists)
                    {
                        var isAssignmentSuccessful = AssignDishToCook(input);
                        if (!isAssignmentSuccessful)
                            break;
                    } 
                    else if(input.Trim().Count() == 1)
                    {
                        CheckForShortcutSymbol(input);
                    }
                    else
                    {
                        Console.WriteLine("This dish is not in the Menu. Please, select a valid one.");
                    }
                        
                }
                else
                {
                    Console.WriteLine("Got null value. Please, try again.");
                }
                    
            }
        }

        public bool AssignDishToCook(string input)
        {
            var lessLoadedCook = Cooks.Where(x => x.Dishes.Count() < 5).OrderBy(x => x.Dishes.Count()).FirstOrDefault();

            if (lessLoadedCook == null)
            {
                Console.WriteLine("No cooks available");
                return false;
            }

            var selectedDish = Dishes.FirstOrDefault(x => x.Name.ToLower() == input.ToLower());
            lessLoadedCook.Dishes.Add(selectedDish);
            var estimatedCookingTime = lessLoadedCook.Dishes.Sum(x => x.EstimatedCookingTime);
            Console.WriteLine("The estimated cooking finish time: " + estimatedCookingTime + "minutes");

            return true;
        }

        public void CheckForShortcutSymbol(string input)
        {
            switch ((input.Trim().ToLower()))
            {
                case "q":
                    Environment.Exit(0);
                    break;
                case "z":
                    UserInterface.ClearScreen();
                    break;
                case "m":
                    UserInterface.ShowDishes(Dishes);
                    break;
                default:
                    Console.WriteLine("This dish is not in the Menu. Please, select a valid one.");
                    break;
            }
        }

        public void SetCooksData()
        {
            var repo = new CookRepository();
            Cooks = repo.GetAll();
        }

        public void SetDishesData()
        {
            var repo = new DishRepository();
            Dishes = repo.GetAll();
        }
    }
}
