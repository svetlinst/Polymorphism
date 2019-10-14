namespace Vehicles
{
    using System;
    public class Car : Vehicle
    {

        public Car(double fuelQuantity, double fuelConsumption):base(fuelQuantity, fuelConsumption + 0.9)
        {
            
        }
    }
}
