using System;

namespace HW06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[10];
            Console.WriteLine("Enter nine random numbers in order from 0 to 255 (after entering each number, press Enter):");
            for (int x = 0; x < 9; x++)
            {
                Console.Write("Number " + (x + 1) + " is?: ");
                data[x] = byte.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array before inserting a number:");
            for (int x = 0; x < 10; x++)
            {
                if (x != 9)
                {
                    Console.Write(data[x] + " ");
                }
                else Console.WriteLine(data[x]);
            }
            Console.WriteLine("Enter last random number from 0 to 255 and its position in the array from 0 to 9 (after entering each number, press Enter):");
            Console.Write("Number 10 is?: ");
            byte last_number = byte.Parse(Console.ReadLine());
            int number_position = 10;
            int read_position;
            do
            {
                Console.Write("Its position in the array is?: ");
                read_position = int.Parse(Console.ReadLine());
                if (read_position >= 0 && read_position <= 9)
                {
                    number_position = read_position;
                }
                else Console.WriteLine("Wrong number position!!! Reenter!!!");
            }
            while (number_position > 9);
            for (int x = 9; x >= read_position; x--)
            {
                data[x] = data[x - 1];
            }
            data[read_position] = last_number;
            Console.WriteLine("Array after inserting a number:");
            for (int x = 0; x < 10; x++)
            {
                if (x != 9)
                {
                    Console.Write(data[x] + " ");
                }
                else Console.WriteLine(data[x]);
            }
        }
    }
}