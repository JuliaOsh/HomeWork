using System;

namespace Lesson3_3
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Say something: ");
            string word = Console.ReadLine();
            string vs = "";

            int i = word.Length - 1;
            while (i > -1)
            {
                vs += word[i];
                i--;
            }
            Console.WriteLine(vs);
        }
    }
}
