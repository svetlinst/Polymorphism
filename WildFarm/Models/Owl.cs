namespace WildFarm.Models
{
    using System;
    public class Owl : Bird
    {
        public Owl(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
        {
            this.NotEatbleFood.Add("Vegetable");
            this.NotEatbleFood.Add("Fruit");
            this.NotEatbleFood.Add("Seeds");
            this.WeightModifier = 0.25;

        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
