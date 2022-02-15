using System;
namespace Lesson4_1
{
    class Task1
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(GetFullName("Ivanov", "Ivan", "Ivanovich"));
                Console.WriteLine(GetFullName("Andreev", "Andrey", "Andreevich"));
                Console.WriteLine(GetFullName("Martinov", "Martin", "Martinovich"));
                Console.WriteLine(GetFullName("Petrov", "Petr", "Petrovich"));
            }
            static string GetFullName(string firstName, string lastName, string patronymic)
            {
                return ($"{lastName} {firstName} {patronymic}");
            }
        }
    }
}
