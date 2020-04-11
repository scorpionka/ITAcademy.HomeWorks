using System;

namespace Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport passengers = new Airport();
            Person newPersonMe = new Person("kuzmitski", "aliaksei", "vladimirovich", "mp3634182", "riga140320");
            Person newPersonMom = new Person("smeyan", "valentsina", "anatolievna", "mc5648512", "tallin240578");
            passengers.AddToBase(newPersonMe);
            passengers.AddToBase(newPersonMom);
            passengers.BaseCount();
            passengers.BasePrintData();
            newPersonMe.Greeting();
            //newPerson.GetFullData(ref newPerson);
            newPersonMe.PersonAccost();
            Console.WriteLine("Check your personal info!");
            newPersonMe.PrintAll();
            Console.WriteLine(newPersonMe.Accost + "! Please, follow to the registration desk.");
            Console.WriteLine("\n" + "At the registration desk");
            Console.WriteLine("Show your passport!");
            string passportDetails = Console.ReadLine();
            Person checkingPerson = passengers.CheckRegistration(passportDetails);
            checkingPerson.PrintAll();
            if (checkingPerson.LastName.Equals("NO_VALUE"))
            {
                Console.WriteLine("No match! Go home!");
                System.Environment.Exit(666);
            }
            Console.WriteLine("Did you register online? y - yes, n - no");

        }
    }
}
