using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        public const ushort MaxSpeedPublic = 250;
        protected const ushort MaxSpeedProtected = 300;
        internal const ushort MaxSpeedInternal = 280;
        protected internal const ushort MaxSpeedProtectedInternal = 270;
        private const ushort MaxSpeedPrivate = 320;
        private protected const ushort MaxSpeedPrivateProtected = 240;

        public string modelPublic = "Honda";
        protected string modelProtected = "Honda";
        internal string modelInternal = "Honda";
        protected internal string modelProtectedInternal = "Honda";
        private string modelPrivate = "Honda";
        private protected string modelPrivateProtected = "Honda";

        public int mileagePublic = 10_000;
        protected int mileageProtected = 10_000;
        internal int mileageInternal = 10_000;
        protected internal int mileageProtectedInternal = 10_000;
        private int mileagePrivate = 10_000;
        private protected int mileagePrivateProtected = 10_000;

        public void RacingPublic()
        {
            Console.WriteLine("private const in a public method from Motorcycle: Max speed " + Motorcycle.MaxSpeedPrivate);
            Console.WriteLine(modelPublic + " is good motorcycle!");
        }
        protected void RacingProtected()
        {
            Console.WriteLine("private const in a protected method from Motorcycle: Max speed " + Motorcycle.MaxSpeedProtected);
            Console.WriteLine(modelProtected + " is fast motorcycle!");
        }
        internal void RacingInternal()
        {
            Console.WriteLine(modelInternal + " is good motorcycle!");
        }
        protected internal void RacingProtectedInternal ()
        {
            Console.WriteLine("private protected const in a protected internal method from Motorcycle: Max speed " + Motorcycle.MaxSpeedPrivateProtected);
            Console.WriteLine(modelProtectedInternal + " isn't fast motorcycle!");
        }
        private void RacingPrivate()
        {
            Console.WriteLine(modelPrivate + " is good motorcycle!");
        }
        private protected void RacingPrivateProtected ()
        {
            Console.WriteLine(modelPrivateProtected + " is good motorcycle!");
        }
    }
}
