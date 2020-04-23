using System;

namespace HW_12
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public ushort Year { get; set; }
        public int Odometer { get; set; }
        public void PrintMotorcycleInfo(Motorcycle motorcycle)
        {
            Console.WriteLine($"Id = {motorcycle.Id}, Name = {motorcycle.Name}, Model = {motorcycle.Model}, " +
                $"Odometer = {motorcycle.Odometer}, Year = {motorcycle.Year}");
        }
    }
}