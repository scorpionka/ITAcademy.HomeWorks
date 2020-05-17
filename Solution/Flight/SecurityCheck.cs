using System;

namespace Flight
{
    public class SecurityCheck : Airport
    {
        public void PassingSecurityCheck()
        {
            Console.WriteLine("\n" + "At the security check.");
            Console.WriteLine("\n" + "Do you have items for inspection? y - yes, n - no");
            char answer = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            if (answer.Equals('y'))
            {
                Console.WriteLine("Put things here and go through the frame!");
            }
            else if (answer.Equals('n'))
            {
                Console.WriteLine("Go through the frame!");
            }
            else
            {
                Console.WriteLine("We have a terrorist! Attention!");
                Console.WriteLine("Hey you, freak! Lie on the floor, hands behind your back, otherwise we shoot !!!");
                System.Environment.Exit(911);
            }
        }
    }
}