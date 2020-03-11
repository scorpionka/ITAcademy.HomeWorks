using System;

namespace HW03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a1 = 2;
            Console.WriteLine(a1.GetType());
            System.SByte a2 = 2;
            Console.WriteLine(a2.GetType());
            short a3 = 5543;
            Console.WriteLine(a3.GetType());
            System.Int16 a4 = 5543;
            Console.WriteLine(a4.GetType());
            int a5 = 636464;
            Console.WriteLine(a5.GetType());
            System.Int32 a6 = 636464;
            Console.WriteLine(a6.GetType());
            long a7 = -435353535;
            Console.WriteLine(a7.GetType());
            System.Int64 a8 = -435353535;
            Console.WriteLine(a8.GetType());
            byte a9 = 113;
            Console.WriteLine(a9.GetType());
            System.Byte a10 = 113;
            Console.WriteLine(a10.GetType());
            ushort a11 = 1126;
            Console.WriteLine(a11.GetType());
            System.UInt16 a12 = 1126;
            Console.WriteLine(a12.GetType());
            char a13 = 'm';
            Console.WriteLine(a13.GetType());
            System.Char a14 = 'm';
            Console.WriteLine(a14.GetType());
            uint a15 = 4353535;
            Console.WriteLine(a15.GetType());
            System.UInt32 a16 = 4353535;
            Console.WriteLine(a16.GetType());
            ulong a17 = 987543244;
            Console.WriteLine(a17.GetType());
            System.UInt64 a18 = 987543244;
            Console.WriteLine(a18.GetType());
            float a19 = 12437.347F;
            Console.WriteLine(a19.GetType());
            System.Single a20 = 12437.347F;
            Console.WriteLine(a20.GetType());
            double a21 = -96934.67893;
            Console.WriteLine(a21.GetType());
            System.Double a22 = -96934.67893;
            Console.WriteLine(a22.GetType());
            decimal a23 = 485487587383874686392M;
            Console.WriteLine(a23.GetType());
            System.Decimal a24 = 485487587383874686392M;
            Console.WriteLine(a24.GetType());
            object a25 = 1974;
            Console.WriteLine(a25.GetType());
            System.Object a26 = 1974;
            Console.WriteLine(a26.GetType());
            string a27 = "Hello!";
            Console.WriteLine(a27.GetType());
            System.String a28 = "Hello!";
            Console.WriteLine(a28.GetType());
        }
    }
}
