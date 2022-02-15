using System;
using System.IO;

namespace Lesson5_2
{
    class Task2
    {
        static void Main(string[] args)
        {
            string textfile = @"C:\Homework\Homework\Lesson5-2\startup.txt";          
            File.AppendAllText(textfile, Convert.ToString(DateTime.Now) + Environment.NewLine);
        }
    }
}
