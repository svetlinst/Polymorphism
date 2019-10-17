namespace WildFarm.Models
{
    using System;
    public class Cat : Feline
    {
        public Cat(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
        {
            this.NotEatbleFood.Add("Fruit");
            this.NotEatbleFood.Add("Seeds");
            this.WeightModifier = 0.3;

        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
