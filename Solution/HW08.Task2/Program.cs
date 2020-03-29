using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW08.Task2
{
    class Program
    {
        static void TrimStringArray(string[] trimming_array)
        {
            for (int x = 0; x < trimming_array.Length; x++)
            {
                trimming_array[x] = trimming_array[x].Trim(' ');
            }
        }

        static int MaxWordIndex(string analyzing_text)
        {
            string[] temp_words = analyzing_text.Split(' ');
            int index_max_word = 0;
            TrimStringArray(temp_words);
            for (int x = 1; x < temp_words.Length; x++)
            {
                if (temp_words[x].Length > temp_words[index_max_word].Length)
                {
                    index_max_word = x;
                }
            }
            return index_max_word;
        }

        static int MinWordIndex(string analyzing_text)
        {
            string[] temp_words = analyzing_text.Split(' ');
            int index_min_word = 0;
            TrimStringArray(temp_words);
            for (int x = 1; x < temp_words.Length; x++)
            {
                if (temp_words[x].Length < temp_words[index_min_word].Length)
                {
                    index_min_word = x;
                }
            }
            return index_min_word;
        }

        static void DeleteMaxLong(ref string _text)
        {
            int index = MaxWordIndex(_text);
            string[] words = _text.Split(' ');
            TrimStringArray(words);
            string[] final_words = new string[words.Length - 1];
            for (int x = 0, y = 0; x < words.Length; x++, y++)
            {
                if (x != index)
                {
                    final_words[y] = words[x];
                }
                else y--;
            }
            _text = String.Join(" ", final_words);
        }

        static void ReplaceLongShort(ref string _text)
        {
            int index_max = MaxWordIndex(_text);
            int index_min = MinWordIndex(_text);
            string[] words = _text.Split(' ');
            TrimStringArray(words);
            string temp_word = words[index_max];
            words[index_max] = words[index_min];
            words[index_min] = temp_word;
            _text = String.Join(" ", words);
        }

        static int CalculateChars(string _text)
        {
            _text = _text.Replace(" ", "");
            return _text.Length;
        }

        static string[] TransformIntoSortedArray(string start_text)
        {
            string[] words = start_text.Split(' ');
            TrimStringArray(words);
            string[] sorted_words = new string[words.Length];
            for (int x = 0; x < sorted_words.Length; x++)
            {
                string[] temp_words = start_text.Split(' ');
                TrimStringArray(temp_words);
                sorted_words[x] = temp_words[MaxWordIndex(start_text)];
                DeleteMaxLong(ref start_text);
            }
            return sorted_words;
        }

        static void Main(string[] args)
        {
            string text = ";outstanding abba. hello; :max understand,"; // Or "string text = Console.ReadLine();"
            char command = ' ';
            while (command.Equals('e') == false)
            {
                Console.WriteLine("Enter a command (DELETE_MAX_LONG - d, REPLACE_LONG_SHORT - r," +
                "CALCULATE_CHARS - c, TRANSFORM_INTO_ARRAY - t, END_OF_PROGRAM - e)");
                command = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (command)
                {
                    case 'd':
                        Console.WriteLine(text);
                        Console.WriteLine("DELETE_MAX_LONG");
                        DeleteMaxLong(ref text);
                        Console.WriteLine(text);
                        break;
                    case 'r':
                        Console.WriteLine(text);
                        Console.WriteLine("REPLACE_LONG_SHORT");
                        ReplaceLongShort(ref text);
                        Console.WriteLine(text);
                        break;
                    case 'c':
                        Console.WriteLine(text);
                        Console.WriteLine("CALCULATE_CHARS");
                        Console.WriteLine("Number of chars: " + CalculateChars(text));
                        break;
                    case 't':
                        Console.WriteLine(text);
                        Console.WriteLine("TRANSFORM_INTO_ARRAY");
                        string[] resulting_array = TransformIntoSortedArray(text);
                        foreach (var x in resulting_array)
                        {
                            Console.WriteLine(x);
                        }
                        command = 'e';
                        break;
                    case 'e':
                        break;
                    default:
                        Console.WriteLine("ENTER_A_COMMAND!!!");
                        break;
                }
            }
            Console.WriteLine("END_OF_PROGRAM!");
        }
    }
}