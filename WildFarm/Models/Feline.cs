namespace WildFarm.Models
{
    using System;
    public abstract class Feline : Mammal
    {
        public string Breed { get; protected set; }
        public Feline(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion)
        {
            this.Breed = breed;
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
