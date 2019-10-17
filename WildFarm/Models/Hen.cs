namespace WildFarm.Models
{
    using System;
    public class Hen : Bird
    {
        public Hen(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
        {
            this.WeightModifier = 0.35;

        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
