namespace Vehicles
{
    using System;
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        public double FuelModifier { get; protected set; } = 1;

        public double FuelQuantity
        {
            get => this.fuelQuantity;
            protected set
            {
                if (value>this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }
        public double FuelConsumption
        {
            get => this.fuelConsumption;
            protected set
            {
                this.fuelConsumption = value;
            }
        }
        public double TankCapacity
        {
            get => this.tankCapacity;
            protected set
            {
                this.tankCapacity = value;
            }
        }

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
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
            if (quantity<=0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }
            var availableSpace = this.TankCapacity - this.FuelQuantity;
            if (quantity > availableSpace)
            {
                throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
            }
            this.FuelQuantity += quantity*this.FuelModifier;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name.ToString()}: {this.FuelQuantity:f2}" ;
        }
    }
}
