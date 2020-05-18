using log4net;
using log4net.Config;
using System;

[assembly: XmlConfigurator(ConfigFile = "app.config", Watch = true)]

namespace HW_12
{
    class Program
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            log.Info("Program start!");
            MotorcycleRepository motorcycles = new MotorcycleRepository();
            log.Info("Repository created!");
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
            log.Info("New motorcycle information added!");
            Console.WriteLine("\n");
            motorcycles.PrintMotorcycleRepository(motorcycles);
            Motorcycle getIdTest = motorcycles.GetMotorcycleByID(3);
            Motorcycle getIdTestNull = motorcycles.GetMotorcycleByID(10);
            log.Info("Motorcycle information received!");
            Console.WriteLine("\n");
            getIdTest.PrintMotorcycleInfo(getIdTest);
            getIdTestNull.PrintMotorcycleInfo(getIdTestNull);
            motorcycles.DeleteMotorcycle(2);
            motorcycles.DeleteMotorcycle(15);
            log.Info("Motocycle information deleted!");
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
            log.Info("Motocycle information updated!");
            Console.WriteLine("\n");
            motorcycles.PrintMotorcycleRepository(motorcycles);
            log.Info("The program is completed!");
        }
    }
}