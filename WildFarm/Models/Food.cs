namespace WildFarm.Models
{
    using System;
    public abstract class Food
    {
        public int Quantity { get; protected set; }

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}
