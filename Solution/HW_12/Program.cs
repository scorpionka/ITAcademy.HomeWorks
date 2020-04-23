using System;

namespace HW_12
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorcycleRepository motorcycles = new MotorcycleRepository();
            motorcycles.PrintMotorcycleRepository(motorcycles);
            Motorcycle newMotorcycle = new Motorcycle()
            {
                Id = 5,
                Name = "Minsk",
                Model = "GOOSE 400",
                Odometer = 17_000,
                Year = 2020
            };
            motorcycles.CreateMotorcycle(newMotorcycle);
            Console.WriteLine("\n");
            motorcycles.PrintMotorcycleRepository(motorcycles);
            Motorcycle getIdTest = motorcycles.GetMotorcycleByID(3);
            Motorcycle getIdTestNull = motorcycles.GetMotorcycleByID(10);
            Console.WriteLine("\n");
            getIdTest.PrintMotorcycleInfo(getIdTest);
            getIdTestNull.PrintMotorcycleInfo(getIdTestNull);
            motorcycles.DeleteMotorcycle(2);
            motorcycles.DeleteMotorcycle(15);
            Console.WriteLine("\n");
            motorcycles.PrintMotorcycleRepository(motorcycles);
            Motorcycle updateTest = new Motorcycle()
            {
                Id = 5,
                Name = "Minsk",
                Model = "GOOSE 400",
                Odometer = 25_000,
                Year = 2019
            };
            motorcycles.UpdateMotorcycle(updateTest);
            Console.WriteLine("\n");
            motorcycles.PrintMotorcycleRepository(motorcycles);
        }
    }
}