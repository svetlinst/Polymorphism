namespace WildFarm.Models
{
    using System;
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; protected set; }

        public Mammal(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten)
        {
            this.LivingRegion = livingRegion;
        }
    }
}
