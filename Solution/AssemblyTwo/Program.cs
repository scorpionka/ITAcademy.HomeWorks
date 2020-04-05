using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle daughterMoto = new Motorcycle();

            //only public available!
            daughterMoto.modelPublic = "BMW";
            Console.WriteLine("public field from another assembly: " + daughterMoto.modelPublic);
            daughterMoto.mileagePublic = 50_000;
            Console.WriteLine("public field from another assembly: " + daughterMoto.mileagePublic);
            Console.Write("\n");
            //private const in a public method
            daughterMoto.RacingPublic();

            //only public available!
            Chopper myWifeChopper = new Chopper();
            myWifeChopper.modelPublic = "Harley Davidson";
            Console.WriteLine("\npublic field from another assembly: " + myWifeChopper.modelPublic);
            Console.WriteLine("public const from another assembly: " + Chopper.MaxSpeedPublic);
            Console.Write("\n");
            myWifeChopper.ChopperRacingProtected();
            myWifeChopper.ChopperRacingProtectedInternal();
        }
    }
}
