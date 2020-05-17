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
        public void AddToBaseAfterCheckIn(Person newPerson)
        {
            passengers.Add(new Person()
            {
                RegistrationStatus = newPerson.RegistrationStatus,
                BoardingPass = newPerson.BoardingPass,
                BaggageStatus = newPerson.BaggageStatus,
                BaggageId = newPerson.BaggageId,
                Terminal = newPerson.Terminal,
                GateNumber = newPerson.GateNumber,
            });
        }
        public Person CheckPassport(string passportDetails)
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
        //Methods BaseCount() & BasePrintData() for self-tests
        public void BaseCount()
        {
            Console.WriteLine(passengers.Count);
        }
        public void BasePrintData()
        {
            foreach (Person aPerson in passengers)
            {
                Console.WriteLine("Last name: " + aPerson.LastName);
                Console.WriteLine("First name: " + aPerson.FirstName);
                Console.WriteLine("Patronymic: " + aPerson.Patronymic);
                Console.WriteLine("Passport data: " + aPerson.PassportData);
                Console.WriteLine("Flight number: " + aPerson.FlightNumber);
                Console.WriteLine("Registration status: " + aPerson.RegistrationStatus);
                Console.WriteLine("Boarding pass: " + aPerson.BoardingPass);
                Console.WriteLine("Baggage status: " + aPerson.BaggageStatus);
                Console.WriteLine("Baggage id: " + aPerson.BaggageId);
                Console.WriteLine("Terminal: " + aPerson.Terminal);
                Console.WriteLine("GateNumber: " + aPerson.GateNumber);
            }
        }
    }
}