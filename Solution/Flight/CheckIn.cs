using System;

namespace Flight
{
    public class CheckIn : Airport
    {
        public void PassingCheckIn(Airport passengers)
        {
            Console.WriteLine("\n" + "At the registration desk.");
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
            if (checkingPerson.RegistrationStatus.Equals(true))
            {
                Console.WriteLine("Your registration is OK! Present your ticket!");
            }
            else
            {
                Console.WriteLine("We will register you now and we will print your ticket. You have to pay 50 dollars.");
            }
            Console.WriteLine("Do you have any luggage? y - yes, n - no");
            char answer = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            if (answer.Equals('y'))
            {
                checkingPerson.BaggageStatus = true;
                Console.WriteLine("Now we will check the size and weight of the luggage and we will give you a tag with a code.");
                Guid baggageId = Guid.NewGuid();
                checkingPerson.BaggageId = baggageId;
                Console.WriteLine("Here is your luggage tag: " + checkingPerson.BaggageId);
            }
            else if (answer.Equals('n'))
            {
                checkingPerson.BaggageStatus = false;
            }
            else
            {
                Console.WriteLine("We have a terrorist! Attention!");
                Console.WriteLine("Hey you, freak! Lie on the floor, hands behind your back, otherwise we shoot !!!");
                System.Environment.Exit(911);
            }
            Guid boardingPass = Guid.NewGuid();
            checkingPerson.BoardingPass = boardingPass;
            Console.WriteLine("Here is your boarding pass showing the terminal and gate number: " + checkingPerson.BoardingPass);
            Console.WriteLine("Terminal: " + checkingPerson.Terminal);
            Console.WriteLine("Gate: " + checkingPerson.GateNumber);
            checkingPerson.AddToBaseAfterCheckIn(checkingPerson);
        }
    }
}