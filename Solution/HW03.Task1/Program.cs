using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //a) Явное преобразование типов
            //1) Преобразование double в int
            double a1 = 105.248;
            System.Console.WriteLine(a1.GetType());
            System.Console.WriteLine(a1);
            int a2;
            a2 = (int)a1;
            System.Console.WriteLine(a2.GetType());
            System.Console.WriteLine(a2);
            //2) Преобразование int в uint
            int b1 = -150;
            System.Console.WriteLine(b1.GetType());
            System.Console.WriteLine(b1);
            uint b2;
            b2 = (uint)b1;
            System.Console.WriteLine(b2.GetType());
            System.Console.WriteLine(b2);
            //3) Преобразование ushort в short
            ushort c1 = 60000;
            System.Console.WriteLine(c1.GetType());
            System.Console.WriteLine(c1);
            short c2;
            c2 = (short)c1;
            System.Console.WriteLine(c2.GetType());
            System.Console.WriteLine(c2);
            //b) Неявное преобразование типов
            //1) Преобразование float в double
            float d1 = 254.142F;
            System.Console.WriteLine(d1.GetType());
            System.Console.WriteLine(d1);
            double d2 = d1;
            System.Console.WriteLine(d2.GetType());
            System.Console.WriteLine(d2);
            //2) Преобразование short в float
            short e1 = 3005;
            System.Console.WriteLine(e1.GetType());
            System.Console.WriteLine(e1);
            float e2 = e1;
            System.Console.WriteLine(e2.GetType());
            System.Console.WriteLine(e2);
            //3) Преобразование byte в double
            byte f1 = 120;
            System.Console.WriteLine(f1.GetType());
            System.Console.WriteLine(f1);
            double f2 = f1;
            System.Console.WriteLine(f2.GetType());
            System.Console.WriteLine(f2);
            //c) Операции упаковки и распаковки
            //1) int
            int g1 = 145;
            Console.WriteLine(g1.GetType());
            Console.WriteLine(g1);
            object g2 = g1;
            Console.WriteLine(g2.GetType());
            Console.WriteLine(g2);
            int g3 = (int)g2;
            Console.WriteLine(g3.GetType());
            Console.WriteLine(g3);
            //2) short
            short h1 = 80;
            Console.WriteLine(h1.GetType());
            Console.WriteLine(h1);
            object h2 = h1;
            Console.WriteLine(h2.GetType());
            Console.WriteLine(h2);
            short h3 = (short)h2;
            Console.WriteLine(h3.GetType());
            Console.WriteLine(h3);
            //3) string
            string i1 = "Hello!";
            Console.WriteLine(i1.GetType());
            Console.WriteLine(i1);
            object i2 = i1;
            Console.WriteLine(i2.GetType());
            Console.WriteLine(i2);
            string i3 = (string)i2;
            Console.WriteLine(i3.GetType());
            Console.WriteLine(i3);
            // Пример с упаковкой int типа и распаковкой в ushort тип
            int j1 = 70000;
            Console.WriteLine(j1.GetType());
            Console.WriteLine(j1);
            object j2 = j1;
            Console.WriteLine(j2.GetType());
            Console.WriteLine(j2);
            ushort j3 = (ushort)(int)j2;
            Console.WriteLine(j3.GetType());
            Console.WriteLine(j3);
            // Пример с упаковкой Логического типа и распаковой в byte тип
            bool k1 = true;
            Console.WriteLine(k1.GetType());
            Console.WriteLine(k1);
            object k2 = k1;
            Console.WriteLine(k2.GetType());
            Console.WriteLine(k2);
            byte k3 = Convert.ToByte(k2);
            Console.WriteLine(k3.GetType());
            Console.WriteLine(k3);
            // Пример с упаковкой char типа и распаковкой в int тип
            char l1 = 'v';
            Console.WriteLine(l1.GetType());
            Console.WriteLine(l1);
            object l2 = l1;
            Console.WriteLine(l2.GetType());
            Console.WriteLine(l2);
            int l3 = (int)(char)l2;
            Console.WriteLine(l3.GetType());
            Console.WriteLine(l3);
        }
    }
}