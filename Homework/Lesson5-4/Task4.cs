using System;
using System.IO;

namespace Lesson5_4
{
    class Task4
    {
        static void Main(string[] args)
        {
            string workDir = @"C:\Homework";
            string catalog = @"C:\Homework\Homework\Lesson5-4\Calatog.txt";

            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);
            File.WriteAllLines(catalog, entries);          
        }
    }
}

