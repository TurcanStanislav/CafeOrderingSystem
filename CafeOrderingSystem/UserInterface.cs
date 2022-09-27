using Business.Domain.Dishes;
using System;
using System.Collections.Generic;

namespace CafeOrderingSystem
{
    public class UserInterface
    {
        protected static int cursorXPosition;
        protected static int cursorYPosition;

        public static void ShowDishes(IEnumerable<Dish> dishes)
        {
            Console.Clear();
            foreach(var dish in dishes)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Dish name: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(dish.Name);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Dish description: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(dish.Description);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Dish ingredients: ");
                Console.ForegroundColor = ConsoleColor.White;

                foreach(var ingredient in dish.Ingredients)
                {
                    var length = dish.Ingredients.Count;
                    if (dish.Ingredients[length-1] != ingredient)
                        Console.Write(ingredient.Name + ", ");
                    else
                        Console.Write(ingredient.Name);
                    
                }
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Dish price: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(dish.Price);
                Console.WriteLine("\n");
            }
        }

        public static void AskForDish()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Introduce the name of dish: ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ClearScreen()
        {
            Console.Clear();
        }

        public static void ShowMainMenu()
        {
            cursorXPosition = Console.CursorLeft;
            cursorYPosition = Console.CursorTop;

            Console.SetCursorPosition(0, cursorYPosition + 2);
            Console.WriteLine("                                                                                                                    ");
            Console.WriteLine("                                                                                                                    ");
            Console.WriteLine("                                                                                                                    ");
            Console.WriteLine("                                                                                                                    ");
            Console.WriteLine("                                                                                                                    ");
            Console.SetCursorPosition(0, cursorYPosition + 5);
            Console.WriteLine("                                              ______________________________");
            Console.WriteLine("                                                 | Cafe Ordering System |");
            Console.WriteLine("      --------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                              Press Q to quit   |   Z to clear screen    |   M to show Menu    ");
            Console.WriteLine("      --------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(cursorXPosition, cursorYPosition);
        }
    }
}
