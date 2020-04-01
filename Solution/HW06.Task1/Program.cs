using System;

namespace HW06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data1 = new int[10];
            int[] data2 = new int[10];
            int[] final_data = new int[10];
            Random rnd = new Random();
            for (int x = 0; x < 10; x++)
            {
                data1[x] = rnd.Next(0, 255);
            }
            Console.Clear();
            Console.WriteLine("Enter ten random numbers in order from 0 to 255 (after entering each number, press Enter):");
            int input_number = 0;
            for (int x = 0; x < 10; x++)
            {
                input_number = int.Parse(Console.ReadLine());
                if ((input_number >= 0) && (input_number <= 255))
                {
                    data2[x] = input_number;
                }
                else
                {
                    Console.WriteLine("Wrong number!!! Reenter, please!");
                    x--;
                }
            }
            for (int x = 0; x < 10; x++)
            {
                final_data[x] = data1[x] + data2[x];
            }
            Console.WriteLine("First array:");
            for (int x = 0; x < 10; x++)
            {
                if (x != 9)
                {
                    Console.Write(data1[x] + " ");
                }
                else Console.WriteLine(data1[x]);
            }
            Console.WriteLine("Second array:");
            for (int x = 0; x < 10; x++)
            {
                if (x != 9)
                {
                    Console.Write(data2[x] + " ");
                }
                else Console.WriteLine(data2[x]);
            }
            Console.WriteLine("Third array:");
            for (int x = 0; x < 10; x++)
            {
                if (x != 9)
                {
                    Console.Write(final_data[x] + " ");
                }
                else Console.WriteLine(final_data[x]);
            }
        }
    }
}