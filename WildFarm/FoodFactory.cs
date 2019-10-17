namespace WildFarm
{
    using System;
    using WildFarm.Models;

    public static class FoodFactory
    {
        public static Food Create(string[] tokens)
        {
            var quantity = int.Parse(tokens[1]);
            var foodType = tokens[0];
            if (foodType == nameof(Vegetable))
            {
                return new Vegetable(quantity);
            }
            else if (foodType == nameof(Meat))
            {
                return new Meat(quantity);

            }
            else if (foodType == nameof(Fruit))
            {
                return new Fruit(quantity);

            }
            else if (foodType == nameof(Seeds))
            {
                return new Seeds(quantity);
            }
            else
            {
                return null;
            }

        }
    }
}
