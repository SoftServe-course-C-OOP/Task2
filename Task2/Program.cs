using System;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What does eat your cat?");
            Cat cat = new Cat();
            cat.Meal(Food.Meat);
            Console.WriteLine($"Your cat's food level is {cat.FoodLevel}");
            Console.WriteLine();
        }
        class Cat
        {
            public int FoodLevel { get; set; } 
            public int Meal(Food food)
            {
                return FoodLevel += (int) food;
            }
        }
        enum Food
        {
            Milk = 10,
            Mouse = 20,
            Chiken = 30,
            Meat = 40
        }
    }
}
