using System;

namespace Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person("kuzmitski", "aliaksei", "vladimirovich", "mp3634182", "riga140320");
            newPerson.Greeting();
            //newPerson.GetFullData(ref newPerson);
            newPerson.PersonAccost();
            Console.WriteLine("Check your personal info!");
            newPerson.PrintAll();
            Console.WriteLine(newPerson.Accost + "! Please, follow to the registration desk.");

        }
    }
}
