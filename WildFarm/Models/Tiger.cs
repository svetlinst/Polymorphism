namespace WildFarm.Models
{
    using System;
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
        {
            this.NotEatbleFood.Add("Vegetable");
            this.NotEatbleFood.Add("Fruit");
            this.NotEatbleFood.Add("Seeds");
            this.WeightModifier = 1;

        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
