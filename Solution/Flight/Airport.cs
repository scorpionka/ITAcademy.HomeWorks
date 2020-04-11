using System;
using System.Collections.Generic;

namespace Flight
{
    public class Airport
    {
        private protected List<Person> passengers = new List<Person>();
        public void AddToBase(Person newPerson)
        {
            passengers.Add(new Person()
            {
                FirstName = newPerson.FirstName,
                LastName = newPerson.LastName,
                Patronymic = newPerson.Patronymic,
                PassportData = newPerson.PassportData,
                FlightNumber = newPerson.FlightNumber
            });
        }
        public Person CheckRegistration(string passportDetails)
        {
            try
            {
                passportDetails = passportDetails.ToUpper();
            }
            catch { }
            if (!passengers.Exists(x => x.PassportData.Equals(passportDetails)))
            {
                Person noName = new Person();
                return noName;
            }
            else
            {
                Console.WriteLine("It's okay!");
                Person checkingPerson = passengers.Find(x => x.PassportData.Equals(passportDetails));
                return checkingPerson;
            }
        }
        public void BaseCount()
        {
            Console.WriteLine(passengers.Count);
        }
        public void BasePrintData()
        {
            foreach (Person aPerson in passengers)
            {
                Console.WriteLine(aPerson.LastName + " " + aPerson.FirstName + " " + aPerson.PassportData + " " + aPerson.FlightNumber);
            }
        }
    }
}