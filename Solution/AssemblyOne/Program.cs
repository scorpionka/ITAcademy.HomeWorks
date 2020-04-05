using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle myMoto = new Motorcycle();

            myMoto.mileagePublic = 7_000; //available
            Console.WriteLine("public field: " + myMoto.mileagePublic);
            //myMoto.mileageProtected = 15_000; //inaccessible
            Console.WriteLine("protected field inaccessible");
            myMoto.mileageInternal = 15_000; //available
            Console.WriteLine("internal field: " + myMoto.mileageInternal);
            myMoto.mileageProtectedInternal = 25_000; //available
            Console.WriteLine("protected internal field: " + myMoto.mileageProtectedInternal);
            //myMoto.mileagePrivate = 15_000; //inaccessible
            Console.WriteLine("private field inaccessible");
            //myMoto.mileagePrivateProtected = 15_000; //inaccessible
            Console.WriteLine("private protected field inaccessible");

            Console.WriteLine("\npublic const: " + Motorcycle.MaxSpeedPublic);
            Console.WriteLine("protected const inaccesible"); //Motorcycle.MaxSpeedProtected
            Console.WriteLine("internal const: " + Motorcycle.MaxSpeedInternal);
            Console.WriteLine("protected internal const: " + Motorcycle.MaxSpeedProtectedInternal);
            Console.WriteLine("private const inaccesible"); //Motorcycle.MaxSpeedPrivate
            Console.WriteLine("private protected const inaccesible"); //Motorcycle.MaxSpeedPrivateProtected

        }
    }
}
