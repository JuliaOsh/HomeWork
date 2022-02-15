using System;
using System.IO;

namespace Lesson5_1
{
    class Task_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Say something: ");
            string text = Console.ReadLine();
            string filename = @"C:\Homework\Homework\Lesson5-1\text.txt";
            File.WriteAllText(filename, text);
        }
    }
}
