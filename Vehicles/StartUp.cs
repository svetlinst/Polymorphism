namespace Vehicles
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Truck truck = new Truck(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Bus bus = new Bus(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
            var commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                var tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    if (tokens[0] == "Drive")
                    {
                        var distance = double.Parse(tokens[2]);
                        if (tokens[1] == "Car")
                        {
                            Console.WriteLine(car.Drive(distance));
                        }
                        else if (tokens[1] == "Truck")
                        {
                            Console.WriteLine(truck.Drive(distance));
                        }
                        else
                        {
                            Console.WriteLine(bus.Drive(distance));
                        }
                    }
                    else if (tokens[0] == "Refuel")
                    {
                        var fuelAmount = double.Parse(tokens[2]);
                        if (tokens[1] == "Car")
                        {
                            car.Refuel(fuelAmount);
                        }
                        else if (tokens[1] == "Truck")
                        {
                            truck.Refuel(fuelAmount);
                        }
                        else
                        {
                            bus.Refuel(fuelAmount);
                        }
                    }
                    else
                    {
                        var distance = double.Parse(tokens[2]);
                        Console.WriteLine(bus.DriveEmpty(distance));
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
                
            }
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());

        }
    }
}
