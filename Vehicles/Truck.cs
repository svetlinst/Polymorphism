namespace Vehicles
{
    using System;
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity):base(fuelQuantity, fuelConsumption+1.6, tankCapacity)
        {
            this.FuelModifier = 0.95;
        }
    }
}
