namespace WildFarm.Models
{
    using System;
    public abstract class Bird : Animal
    {
        public double WingSize { get; protected set; }
        
        public Bird(string name, double weight, int foodEaten, double wingSize):base(name, weight, foodEaten)
        {
            this.WingSize = wingSize;
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
