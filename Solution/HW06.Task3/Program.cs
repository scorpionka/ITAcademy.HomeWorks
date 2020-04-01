using System;
using System.Diagnostics;
using System.Threading;

namespace HW06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int x = 0; x <= data.Length - 1; x++)
            {
                if (x != data.Length - 1)
                {
                    Console.Write(data[x] + " ");
                }
                else Console.WriteLine(data[x]);
            }

            // C# Method
            Array.Reverse(data);
            for (int x = 0; x <= data.Length - 1; x++)
            {
                if (x != data.Length - 1)
                {
                    Console.Write(data[x] + " ");
                }
                else Console.WriteLine(data[x]);
            }

            // My method
            int temp_variable;
            int half_data_lenght;
            int index_data_from_end = data.Length - 1;
            half_data_lenght = data.Length / 2;
            for (int x = 0; x <= half_data_lenght - 1; x++)
            {
                temp_variable = data[index_data_from_end];
                data[index_data_from_end] = data[x];
                data[x] = temp_variable;
                index_data_from_end--;
            }
            for (int x = 0; x <= data.Length - 1; x++)
            {
                if (x != data.Length - 1)
                {
                    Console.Write(data[x] + " ");
                }
                else Console.WriteLine(data[x]);
            }

            //OPTIONAL!!!
            Int64[] data_1 = new Int64[100000000];
            Random rnd = new Random();
            for (Int64 x = 0; x <= data_1.Length -1; x++)
            {
                data_1[x] = rnd.Next();
            }

            // C# Method
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Array.Reverse(data_1);
            timer.Stop();
            Console.WriteLine("C# Method: " + timer.ElapsedMilliseconds + " ms");

            // My method
            Stopwatch timer_1 = new Stopwatch();
            timer_1.Start();
            Int64 temp_variable_1;
            Int64 half_data_lenght_1;
            Int64 index_data_from_end_1 = data_1.Length - 1;
            half_data_lenght_1 = data_1.Length / 2;
            for (int x = 0; x <= half_data_lenght_1 - 1; x++)
            {
                temp_variable_1 = data_1[index_data_from_end_1];
                data_1[index_data_from_end_1] = data_1[x];
                data_1[x] = temp_variable_1;
                index_data_from_end_1--;
            }
            timer_1.Stop();
            Console.WriteLine("My method: " + timer_1.ElapsedMilliseconds + " ms");
        }
    }
}