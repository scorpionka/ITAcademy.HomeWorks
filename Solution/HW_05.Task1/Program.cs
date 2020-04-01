using System;

namespace HW_05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 122; x > 96; x--)
            {
                if (x != 97)
                {
                    Console.Write((char)x + " ");
                }
                else
                {
                    Console.Write((char)x + "\n");
                }
            }
        }
    }
}
