using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        public const ushort MaxSpeedPublic = 250;
        protected const ushort MaxSpeedProtected = 300;
        internal const ushort MaxSpeedInternal = 260;
        protected internal const ushort MaxSpeedProtectedInternal = 320;
        private const ushort MaxSpeedPrivate = 350;
        private protected const ushort MaxSpeedPrivateProtected = 360;

        public string modelPublic = "Ural";
        protected string modelProtected = "Kawasaki";
        internal string modelInternal = "Honda";
        protected internal string modelProtectedInternal = "Harley Davidson";
        private string modelPrivate = "BMW";
        private protected string modelPrivateProtected = "Yamaha";

        public int mileagePublic = 10_000;
        protected int mileageProtected = 12_000;
        internal int mileageInternal = 15_000;
        protected internal int mileageProtectedInternal = 20_000;
        private int mileagePrivate = 30_000;
        private protected int mileagePrivateProtected = 100_000;

        public void RacingPublic()
        {
            Console.WriteLine("Public racing is good!");
            Console.WriteLine("Public const, fields and methods are available everywhere!");
        }
        protected void RacingProtected()
        {
            Console.WriteLine("Protected racing is good!");
        }
        internal void RacingInternal()
        {
            Console.WriteLine("Internal racing is good!");
        }
        protected internal void RacingProtectedInternal ()
        {
            Console.WriteLine("Protected Internal racing is good!");
        }
        private void RacingPrivate()
        {
            Console.WriteLine("Private racing is good!");
        }
        private protected void RacingPrivateProtected ()
        {
            Console.WriteLine("Private Protected racing is good!");
        }
        public void WhereProtectedAvailable ()
        {
        //protected fields, const and methods are available here
        Console.WriteLine("Protected const, fields, methods are available in class Motorcycle!");
            Console.WriteLine("Max speed = " + Motorcycle.MaxSpeedProtected);
            Motorcycle myMoto = new Motorcycle();
            Console.WriteLine("Model: " + myMoto.modelProtected);
            Console.WriteLine("Mileage = " + myMoto.mileageProtected);
            myMoto.RacingProtected();
        }
        public void WherePrivateAvailable()
        {
            //private fields, const and methods are available here
            Console.WriteLine("Private const, fields, methods are available in class Motorcycle!");
            Console.WriteLine("Max speed = " + Motorcycle.MaxSpeedPrivate);
            Motorcycle myMoto = new Motorcycle();
            Console.WriteLine("Model: " + myMoto.modelPrivate);
            Console.WriteLine("Mileage = " + myMoto.mileagePrivate);
            myMoto.RacingPrivate();
        }
        public void WherePrivateProtectedAvailable()
        {
            //private protected fields, const and methods are available here
            Console.WriteLine("Private protected const, fields, methods are available in class Motorcycle!");
            Console.WriteLine("Max speed = " + Motorcycle.MaxSpeedPrivateProtected);
            Motorcycle myMoto = new Motorcycle();
            Console.WriteLine("Model: " + myMoto.modelPrivateProtected);
            Console.WriteLine("Mileage = " + myMoto.mileagePrivateProtected);
            myMoto.RacingPrivateProtected();
        }
    }
}