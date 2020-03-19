using System;

namespace HW_05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (a)
            {
                case 'w':
                    Console.WriteLine("Move forward!");
                    break;
                case 's':
                    Console.WriteLine("Move back!");
                    break;
                case 'a':
                    Console.WriteLine("Move left!");
                    break;
                case 'd':
                    Console.WriteLine("Move right!");
                    break;
                default:
                    Console.WriteLine("Dont't move!");
                    break;
            }
        }
    }
}
