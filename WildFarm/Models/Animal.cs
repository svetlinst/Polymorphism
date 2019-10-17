namespace WildFarm.Models
{
    using System;
    using System.Collections.Generic;

    public abstract class Animal
    {
        public string Name { get; protected set; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }
        public List<string> NotEatbleFood { get; protected set; }

        public double WeightModifier { get; protected set; }

        public Animal(string name, double weight, int foodEaten)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = foodEaten;
            NotEatbleFood = new List<string>();
        }

        public abstract string ProduceSound();

        public virtual void Eat(Food food) 
        {
            var foodType = food.GetType().Name;
            if (this.NotEatbleFood.Contains(foodType))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * this.WeightModifier;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
