using System;
using System.Collections.Generic;

namespace Flight
{
    public class Airport
    {
        private protected List<Person> Passengers = new List<Person>();
        public void AddToBase(Person newPerson)
        {
            Passengers.Add(new Person()
            {
                FirstName = newPerson.FirstName,
                LastName = newPerson.LastName,
                Patronymic = newPerson.Patronymic,
                PassportData = newPerson.PassportData,
                FlightNumber = newPerson.FlightNumber
            });
        }
        public void CheckRegistration(string passportDetails)
        {
            try
            {
                passportDetails = passportDetails.ToUpper();
            }
            catch { }
            if (!Passengers.Exists(x => x.PassportData == passportDetails))
            {
                Console.WriteLine("No match! Go home!");
                Environment.Exit(666);
            }
            else
            {
                Console.WriteLine("It's okay!");
            }
        }
        public void BaseCount()
        {
            Console.WriteLine(Passengers.Count);
        }
        public void BasePrintData()
        {
            foreach (Person aPerson in Passengers)
            {
                Console.WriteLine(aPerson.LastName + " " + aPerson.FirstName + " " + aPerson.PassportData + " " + aPerson.FlightNumber);
            }
        }
    }
}