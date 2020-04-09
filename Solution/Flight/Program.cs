using System;

namespace Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person();
            newPerson.Greeting();
            newPerson.GetFullName();
            newPerson.PersonAccost();
        }
    }
}
