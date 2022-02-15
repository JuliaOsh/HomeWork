using System;
using System.IO;

namespace Lesson5_3
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers [0..255] separated by space: ");
            string numbers = Console.ReadLine();
            string[] array = numbers.Split(' ');
            byte[] arrayByte = new byte[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                arrayByte[i] = Convert.ToByte(array[i]);
            }

            string filename = @"C:\Homework\Homework\Lesson5-3\bytes.bin";
            File.WriteAllBytes(filename, arrayByte);
        }
    }
}
