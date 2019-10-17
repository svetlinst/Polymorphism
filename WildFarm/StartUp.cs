namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    using WildFarm.Models;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string input;
            while ((input = Console.ReadLine())!="End")
            {
                var animalTokens = ParseConsoleInput(input);
                Animal animal = AnimalFactory.Create(animalTokens);
                animals.Add(animal);
                var foodTokens = ParseConsoleInput(Console.ReadLine());
                Food food = FoodFactory.Create(foodTokens);
                Console.WriteLine(animal.ProduceSound());
                try
                {
                    animal.Eat(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        public static string[] ParseConsoleInput(string input)
        {
            return input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
