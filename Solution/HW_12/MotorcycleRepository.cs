﻿using System;
using System.Collections.Generic;

namespace HW_12
{
    public class MotorcycleRepository : Motorcycle, IMotorcycleRepository
    {
        private static List<Motorcycle> motorcycles = new List<Motorcycle>()
        {
            new Motorcycle{Id = 1, Model = "CBR 600 RA", Name = "Honda", Odometer = 20_000, Year = 2019},
            new Motorcycle{Id = 2, Model = "XV950 Racer", Name = "Yamaha", Odometer = 30_000, Year = 2018},
            new Motorcycle{Id = 3, Model = "GSX-S750A", Name = "Suzuki", Odometer = 50_000, Year = 2017},
            new Motorcycle{Id = 4, Model = "Gear Up 2020", Name = "Ural", Odometer = 10_000, Year = 2020}
        };

        public IEnumerable<Motorcycle> GetMotorcycles()
        {
            return motorcycles;
        }

        public Motorcycle GetMotorcycleByID(int motorcycleID)
        {
            Motorcycle motorcycle = motorcycles.Find(x => x.Id.Equals(motorcycleID));
            return motorcycle != null ? motorcycle : new Motorcycle();
        }

        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            motorcycles.Add(motorcycle);
        }

        public void DeleteMotorcycle(int motorcycleID)
        {
            if (motorcycles.Exists(x => x.Id.Equals(motorcycleID)))
            {
                Motorcycle motorcycle = motorcycles.Find(x => x.Id.Equals(motorcycleID));
                motorcycles.Remove(motorcycle);
            }
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            if (motorcycles.Exists(x => x.Id.Equals(motorcycle.Id)))
            {
                Motorcycle motorcycleForUpdate = motorcycles.Find(x => x.Id.Equals(motorcycle.Id));
                motorcycleForUpdate.Model = motorcycle.Model;
                motorcycleForUpdate.Name = motorcycle.Name;
                motorcycleForUpdate.Odometer = motorcycle.Odometer;
                motorcycleForUpdate.Year = motorcycle.Year;
            }
        }
        public void PrintMotorcycleRepository(MotorcycleRepository motorcycles)
        {
            foreach (var aMotorcycle in motorcycles.GetMotorcycles())
            {
                Console.WriteLine($"Id = {aMotorcycle.Id}, Name = {aMotorcycle.Name}, Model = {aMotorcycle.Model}, " +
                    $"Odometer = {aMotorcycle.Odometer}, Year = {aMotorcycle.Year}");
            }
        }
    }
}