using System;
using System.Text;

namespace HW08.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "1a!2.3!!.. 4.!.? 6 7! ..?";
            int index = text.IndexOf('?');
            StringBuilder sb_text_before = new StringBuilder();
            sb_text_before.Append(text, 0, index + 1);
            StringBuilder sb_text_after = new StringBuilder();
            sb_text_after.Append(text, index + 1, text.Length - index - 1);
            sb_text_before = sb_text_before.Replace("!", "");
            sb_text_before = sb_text_before.Replace(".", "");
            sb_text_after = sb_text_after.Replace(" ", "_");
            Console.WriteLine(sb_text_before.ToString() + sb_text_after.ToString());
        }
    }
}