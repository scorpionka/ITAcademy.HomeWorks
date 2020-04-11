using System;

namespace Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person("kuzmitski", "aliaksei", "vladimirovich", "mp3634182", "riga140320");
            Person newPerson1 = new Person("smeyan", "valentsina", "anatolievna", "mc5648512", "tallin240578");
            newPerson1.AddToBase(newPerson1);
            newPerson.Greeting();
            //newPerson.GetFullData(ref newPerson);
            newPerson.PersonAccost();
            Console.WriteLine("Check your personal info!");
            newPerson.PrintAll();
            newPerson.AddToBase(newPerson);
            Console.WriteLine(newPerson.Accost + "! Please, follow to the registration desk.");
            Console.WriteLine("\n" + "At the registration desk");
            Console.WriteLine("Show your passport!");
            //string passportDetails = Console.ReadLine();
            //CheckIn newCheckInPerson = new CheckIn();
            //newCheckInPerson.CheckRegistration(passportDetails);

        }
    }
}
