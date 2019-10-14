namespace Vehicles
{
    using System;
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption +1.4, tankCapacity)
        {

        }

        public string DriveEmpty(double distance)
        {
            this.FuelConsumption -= 1.4;
            return this.Drive(distance);
        }
    }
}
