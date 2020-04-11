using System;

namespace Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport Passengers = new Airport();
            Person newPersonMe = new Person("kuzmitski", "aliaksei", "vladimirovich", "mp3634182", "riga140320");
            Person newPersonMom = new Person("smeyan", "valentsina", "anatolievna", "mc5648512", "tallin240578");
            Passengers.AddToBase(newPersonMe);
            Passengers.AddToBase(newPersonMom);
            Passengers.BaseCount();
            Passengers.BasePrintData();
            newPersonMe.Greeting();
            //newPerson.GetFullData(ref newPerson);
            newPersonMe.PersonAccost();
            Console.WriteLine("Check your personal info!");
            newPersonMe.PrintAll();
            Console.WriteLine(newPersonMe.Accost + "! Please, follow to the registration desk.");
            Console.WriteLine("\n" + "At the registration desk");
            Console.WriteLine("Show your passport!");
            string passportDetails = Console.ReadLine();
            Passengers.CheckRegistration(passportDetails);

        }
    }
}
