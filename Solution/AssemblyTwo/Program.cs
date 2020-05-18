using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle myMoto = new Motorcycle();

            //public fields, const and methods are available everywhere
            Console.WriteLine("Public const, fields, methods:");
            Console.WriteLine("Max speed = " + Motorcycle.MaxSpeedPublic);
            Console.WriteLine("Model: " + myMoto.modelPublic);
            Console.WriteLine("Mileage = " + myMoto.mileagePublic);
            myMoto.RacingPublic();
            Console.WriteLine("");

            //protected fields, const and methods aren't available here
            Console.WriteLine("Protected const, fields, methods aren't accessible from outside the class!");
            //Console.WriteLine("Max speed = " + Motorcycle.MaxSpeedProtected);
            //Console.WriteLine("Model: " + myMoto.modelProtected);
            //Console.WriteLine("Mileage = " + myMoto.mileageProtected);
            //myMoto.RacingProtected();
            Chopper myDadMoto = new Chopper();
            myDadMoto.WhereProtectedAvailableHeir();
            Console.WriteLine("");

            //internal fields, const and methods aren't available here
            Console.WriteLine("Internal const, fields, methods aren't available in this assembly!");
            //Console.WriteLine("Max speed = " + Motorcycle.MaxSpeedInternal);
            //Console.WriteLine("Model: " + myMoto.modelInternal);
            //Console.WriteLine("Mileage = " + myMoto.mileageInternal);
            //myMoto.RacingInternal();
            Console.WriteLine("");

            //protected internal fields, const and methods aren't available here
            Console.WriteLine("Protected internal const, fields, methods are available only from the heir class Chopper in this assembly!");
            //Console.WriteLine("Max speed = " + Motorcycle.MaxSpeedProtectedInternal);
            //Console.WriteLine("Model: " + myMoto.modelProtectedInternal);
            //Console.WriteLine("Mileage = " + myMoto.mileageProtectedInternal);
            //myMoto.RacingProtectedInternal();
            Chopper myDaughterMoto = new Chopper();
            myDaughterMoto.WhereProtectedInternalAvailableHeir();
            Console.WriteLine("");

            //private fields, const and methods aren't available here
            Console.WriteLine("Private const, fields, methods are available only inside the class Motorcycle!");
            //Console.WriteLine("Max speed = " + Motorcycle.MaxSpeedPrivate);
            //Console.WriteLine("Model: " + myMoto.modelPrivate);
            //Console.WriteLine("Mileage = " + myMoto.mileagePrivate);
            //myMoto.RacingPrivate();
            Console.WriteLine("");

            //private protected fields, const and methods aren't available here
            Console.WriteLine("Private protected const, fields, methods are available only inside the class Motorcycle " +
                "and heir class Sportbike in their assembly!");
            //Console.WriteLine("Max speed = " + Motorcycle.MaxSpeedPrivateProtected);
            //Console.WriteLine("Model: " + myMoto.modelPrivateProtected);
            //Console.WriteLine("Mileage = " + myMoto.mileagePrivateProtected);
            //myMoto.RacingPrivateProtected();
            Console.WriteLine("");

            Motorcycle myWifeMoto = new Motorcycle();
            Console.WriteLine("Public class Motorcycle is accessible everywhere!");
            //Sportbike mySisterMoto = new AssemblyOne.Sportbike();
            Console.WriteLine("Internal class Sportbike from other assembly isn't available here");
            Chopper myCousinMoto = new Chopper();
            Console.WriteLine("Internal class Chopper from this assembly is accessible here");
        }
    }
}