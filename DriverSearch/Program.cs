using System;
using System.Collections.Generic;

namespace DriverSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = new List<Driver>
            {
                new Driver(1, 0, 0),
                new Driver(2, 1, 1),
                new Driver(3, 2, 2),
                new Driver(4, 10, 10),
                new Driver(5, 20, 20),
                new Driver(6, 3, 3)
            };

            int orderX = 0;
            int orderY = 0;

            Console.WriteLine("=== SortSearch ===");
            Print(new SortSearch().Find(drivers, orderX, orderY));

            Console.WriteLine("\n=== ManualSearch ===");
            Print(new ManualSearch().Find(drivers, orderX, orderY));

            Console.WriteLine("\n=== QueueSearch ===");
            Print(new QueueSearch().Find(drivers, orderX, orderY));

            Console.ReadLine();
        }

        static void Print(List<Driver> drivers)
        {
            foreach (var d in drivers)
            {
                Console.WriteLine($"Driver {d.Id} ({d.X},{d.Y})");
            }
        }
    }
}