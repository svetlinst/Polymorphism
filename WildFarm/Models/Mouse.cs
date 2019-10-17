namespace WildFarm.Models
{
    using System;
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
        {
            this.NotEatbleFood.Add("Meat");
            this.NotEatbleFood.Add("Seeds");
            this.WeightModifier = 0.1;

        }

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
