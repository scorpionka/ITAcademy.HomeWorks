using System;
using System.Collections.Generic;
using System.Text;
using AssemblyOne;

namespace AssemblyTwo
{
    internal class Chopper: Motorcycle
    {
        public void WhereProtectedAvailableHeir()
        {
            //protected fields, const and methods are available here
            Console.WriteLine("Protected const, fields, methods are available in heir class Chopper even in other assembly!");
            Console.WriteLine("Max speed = " + Chopper.MaxSpeedProtected);
            Chopper myDadMoto = new Chopper();
            Console.WriteLine("Model: " + myDadMoto.modelProtected);
            Console.WriteLine("Mileage = " + myDadMoto.mileageProtected);
            myDadMoto.RacingProtected();
        }
        public void WhereProtectedInternalAvailableHeir()
        {
            //protected internal fields, const and methods are available here
            Console.WriteLine("Protected internal const, fields, methods are available in heir class Chopper even in other assembly!");
            Console.WriteLine("Max speed = " + Chopper.MaxSpeedProtectedInternal);
            Chopper myDaughterMoto = new Chopper();
            Console.WriteLine("Model: " + myDaughterMoto.modelProtectedInternal);
            Console.WriteLine("Mileage = " + myDaughterMoto.mileageProtectedInternal);
            myDaughterMoto.RacingProtectedInternal();
        }
    }
}