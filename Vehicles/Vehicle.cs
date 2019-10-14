namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; protected set; }
        public double FuelConsumption { get; protected set; }

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public virtual string Drive(double distance)
        {
            var fuelRequired = distance * this.FuelConsumption;
            if (this.FuelQuantity >= fuelRequired)
            {
                this.FuelQuantity -= fuelRequired;
                return $"{this.GetType().Name.ToString()} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name.ToString()} needs refueling";
            }
        }
        public virtual void Refuel(double quantity)
        {
            this.FuelQuantity += quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name.ToString()}: {this.FuelQuantity:f2}" ;
        }
    }
}
