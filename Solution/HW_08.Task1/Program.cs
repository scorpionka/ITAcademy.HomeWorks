using System;

namespace HW_08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string poems = Console.ReadLine();
            string[] resulting_poems = poems.Split(';');
            for (int x = 0; x < resulting_poems.Length; x++)
            {
                resulting_poems[x] = resulting_poems[x].Trim();
                resulting_poems[x] = resulting_poems[x].Replace("O", "A");
                Console.WriteLine(resulting_poems[x]);
            }
        }
    }
}