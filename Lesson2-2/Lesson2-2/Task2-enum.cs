using System;

namespace Lesson2_2
{
    class Task2
    {

        enum Months
        { 
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Month number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N < 1 || N > 12)
            {              
                Console.WriteLine("There is no such month in the Earth year");
            }
            else
            {
                Console.WriteLine((Months)N);
            }

        }
    }
}
