namespace WildFarm.Models
{
    using System;
    public static class AnimalFactory
    {
        public static Animal Create(string[] tokens)
        {
            var animalType = tokens[0];
            var name = tokens[1];
            var weight = double.Parse(tokens[2]);

            switch (animalType)
            {
                case nameof(Hen):
                    var wingSize = double.Parse(tokens[3]);
                    return new Hen(name, weight, 0, wingSize);
                case nameof(Owl):
                    wingSize = double.Parse(tokens[3]);
                    return new Owl(name, weight, 0, wingSize);
                case nameof(Cat):
                    var livingRegion = tokens[3];
                    var breed = tokens[4];
                    return new Cat(name, weight, 0, livingRegion, breed);
                case nameof(Tiger):
                    livingRegion = tokens[3];
                    breed = tokens[4];
                    return new Tiger(name, weight, 0, livingRegion, breed);
                case nameof(Dog):
                    livingRegion = tokens[3];
                    return new Dog(name, weight, 0, livingRegion);
                case nameof(Mouse):
                    livingRegion = tokens[3];
                    return new Mouse(name, weight, 0, livingRegion);
            }
            return null;
        }
    }
}
