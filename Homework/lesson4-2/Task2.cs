using System;

namespace Lesson4_2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers separated by space");
            string numbers = Console.ReadLine();
            Console.WriteLine(CalculateSumm(numbers));

            static double CalculateSumm(string numbers)
            {
                string temp = "";
                double summ = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] != ' ')
                    {
                        temp += numbers[i];
                    }
                    else
                    {
                        double tempDouble = Convert.ToDouble(temp);
                        summ += tempDouble;
                        temp = "";
                    }
                }
                return summ + Convert.ToDouble(temp);
            }
        }
    }
}
