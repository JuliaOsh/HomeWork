using System;
namespace HomeWork
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Minimum day temperature: ");
            double minT = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Maximum day temperature: ");
            double maxT = Convert.ToDouble(Console.ReadLine());

            double avTemp = (minT + maxT) / 2;
            Console.WriteLine($"Average temperature: {avTemp}");
        }


    }
}
