using System;

namespace Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport passengers = new Airport();
            Person newPersonMe = new Person();
            newPersonMe.Greeting();
            newPersonMe.GetFullData(ref newPersonMe);
            passengers.AddToBase(newPersonMe);
            newPersonMe.PersonAccost();
            Console.WriteLine("Check your personal info!");
            newPersonMe.PrintAll();
            Console.WriteLine(newPersonMe.Accost + "! Please, follow to the registration desk.");
            CheckIn checkingPerson = new CheckIn();
            checkingPerson.PassingCheckIn(passengers);
            Console.WriteLine(newPersonMe.Accost + "! Proceed to security check and passport control.");
            SecurityCheck securityCheckingPerson = new SecurityCheck();
            securityCheckingPerson.PassingSecurityCheck();
            Console.WriteLine("Proceed to passport control.");
            PassportControl passportCheckingPerson = new PassportControl();
            passportCheckingPerson.PassingPassportControl(passengers);
            Console.WriteLine(newPersonMe.Accost + "! Go to the gate to board the plane! Pleasant flight!" + "\n");
            passengers.BaseCount();
            passengers.BasePrintData();
        }
    }
}