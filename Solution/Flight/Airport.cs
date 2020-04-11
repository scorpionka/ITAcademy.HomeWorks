using System;
using System.Collections.Generic;

namespace Flight
{
    public class Airport
    {
        public List<Person> basePerson = new List<Person>();
        public void AddToBase(Person newPerson)
        {
            Console.WriteLine(basePerson.Count);
            basePerson.Add(new Person()
            {
                FirstName = newPerson.FirstName,
                LastName = newPerson.LastName,
                Patronymic = newPerson.Patronymic,
                PassportData = newPerson.PassportData,
                FlightNumber = newPerson.FlightNumber
            });
            Console.WriteLine(basePerson.Count);
            Console.WriteLine();
            foreach (Person aPerson in basePerson)
            {
                Console.WriteLine(aPerson);
            }
        }
    }
}
