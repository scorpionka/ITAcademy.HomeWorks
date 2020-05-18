using System;

namespace Flight
{
    class PassportControl : Airport
    {
        public void PassingPassportControl(Airport passengers)
        {
            Console.WriteLine("\n" + "At the passport control.");
            Console.WriteLine("\n" + "Show your passport!");
            string passportDetails = Console.ReadLine();
            Person checkingPerson = passengers.CheckPassport(passportDetails);
            checkingPerson.PrintAll();
            if (checkingPerson.LastName.Equals("NO_VALUE"))
            {
                Console.WriteLine("We have a terrorist! Attention!");
                Console.WriteLine("Hey you, freak! Lie on the floor, hands behind your back, otherwise we shoot !!!");
                System.Environment.Exit(911);
            }
        }
    }
}