using CafeOrderingSystem.Entities;
using System;
using System.Collections.Generic;

namespace CafeOrderingSystem
{
    public class UserInterface
    {
        protected static int cursorXPosition;
        protected static int cursorYPosition;

        public static void ShowDishes(IList<Dish> dishes)
        {
            foreach(var dish in dishes)
            {
                Console.WriteLine(dish.Name);
                Console.WriteLine(dish.Description);
                foreach(var ingredient in dish.Ingredients)
                {
                    Console.Write(ingredient.Name + "   ");
                }
                Console.WriteLine();
                Console.WriteLine(dish.Price);
                Console.WriteLine("\n");
            }
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
            Console.WriteLine("                                          Press Q to quit   |   Z to clear screen    ");
            Console.WriteLine("      --------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(cursorXPosition, cursorYPosition);
        }
        //public static void ShowResult(char _operator, decimal operand1, decimal operand2, decimal result)
        //{
        //    Console.BackgroundColor = ConsoleColor.White;
        //    Console.ForegroundColor = ConsoleColor.Black;
        //    Console.WriteLine($"{operand1:F3} {_operator:F3} {operand2:F3} = {result:F8}");
        //    Console.ResetColor();
        //}
    }
}
