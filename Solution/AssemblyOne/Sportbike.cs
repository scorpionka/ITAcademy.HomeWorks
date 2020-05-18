using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    internal class Sportbike: Motorcycle
    {
        public void WherePrivateProtectedAvailableHeir()
        {
            //private protected fields, const and methods are available here
            Console.WriteLine("Private protected const, fields, methods are available in heir class Sportbike!");
            Console.WriteLine("Max speed = " + Sportbike.MaxSpeedPrivateProtected);
            Sportbike myMoto = new Sportbike();
            Console.WriteLine("Model: " + myMoto.modelPrivateProtected);
            Console.WriteLine("Mileage = " + myMoto.mileagePrivateProtected);
            myMoto.RacingPrivateProtected();
        }
    }
}