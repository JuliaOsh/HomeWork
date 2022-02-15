using System;

namespace Lesson2_3
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some number: ");
            double input = Convert.ToDouble(Console.ReadLine());

            double check = input % 2;
            if (check == 0) 
                {
                    Console.WriteLine($"Number {input} is even");
                }
            else
                {
                Console.WriteLine($"Number {input} is odd");
            }

        }
    }
}
