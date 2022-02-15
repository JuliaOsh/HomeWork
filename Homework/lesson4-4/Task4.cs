using System;

namespace Lesson4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetFibonachi(n));

            static int GetFibonachi(int n)
            {
                if (n == 0)
                {
                    return 0;
                }
                else if (n == 1)
                {
                    return 1;
                }
                else 
                {
                    return GetFibonachi(n - 2) + GetFibonachi(n - 1);
                }
            }
        }
    }
}
