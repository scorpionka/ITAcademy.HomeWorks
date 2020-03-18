using System;
using System.IO;

namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Чтение исходного файла в папке Temp
            //2. Сохраняем в строке код из файла
            //3. Освобождаем ресурсы класса textReader
            //4. Сохраняем в строке код из файла, разбивая на символы
            //5. Создаем массив для хранения конечного результата
            //6. Заускаем цикл, в котором конвертируем исходный код
            //7. В том же цикле сохраняем новый код в массиве
            //8. Записываем полученный код в файл картинки в папке Temp
            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            textReader.Dispose();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes);
        }
    }
}