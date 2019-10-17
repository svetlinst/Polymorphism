namespace WildFarm.Models
{
    using System;
    public class Dog : Mammal
    {
        public Dog(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
        {
            this.NotEatbleFood.Add("Vegetable");
            this.NotEatbleFood.Add("Fruit");
            this.NotEatbleFood.Add("Seeds");
            this.WeightModifier = 0.4;
        }

        public override string ProduceSound()
        {
            return "Woof!"; 
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
