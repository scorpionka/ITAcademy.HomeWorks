using System;

namespace Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person();
            newPerson.Greeting();
            newPerson.GetFullData(ref newPerson);
            newPerson.PersonAccost();
            Console.WriteLine("Check your personal info!");
            newPerson.PrintAll();

        }
    }
}
