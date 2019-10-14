namespace Vehicles
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car(double.Parse(input[1]), double.Parse(input[2]));
            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Truck truck = new Truck(double.Parse(input[1]), double.Parse(input[2]));
            var commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                var tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0]=="Drive")
                {
                    if (tokens[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(tokens[2])));
                    }
                    else
                    {
                        Console.WriteLine(truck.Drive(double.Parse(tokens[2])));
                    }
                }
                else
                {
                    if (tokens[1] == "Car")
                    {
                        car.Refuel(double.Parse(tokens[2]));
                    }
                    else
                    {
                        truck.Refuel(double.Parse(tokens[2]));
                    }
                }
            }
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());

        }
    }
}
