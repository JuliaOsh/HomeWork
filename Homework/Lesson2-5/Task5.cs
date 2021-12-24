using System;

namespace Lesson2_5
{
    class Task5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minimum day temperature: ");
            double minT = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Maximum day temperature: ");
            double maxT = Convert.ToDouble(Console.ReadLine());

            double avTemp = (minT + maxT) / 2;
            Console.WriteLine($"Average temperature: {avTemp}");

            Console.WriteLine("Month number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            string monthName = "";

            switch (N)
            {
                case 1:
                    monthName = "January";
                    break;

                case 2:
                    monthName = "February";
                    break;

                case 3:
                    monthName = "March";
                    break;

                case 4:
                    monthName = "April";
                    break;

                case 5:
                    monthName = "May";
                    break;

                case 6:
                    monthName = "June";
                    break;

                case 7:
                    monthName = "July";
                    break;

                case 8:
                    monthName = "August";
                    break;

                case 9:
                    monthName = "September";
                    break;

                case 10:
                    monthName = "October";
                    break;

                case 11:
                    monthName = "November";
                    break;

                case 12:
                    monthName = "December";
                    break;

                default:
                    Console.WriteLine("There is no such month in the Earth year");
                    break;
            }

            if ((N == 12 || N == 1 || N == 2) && (avTemp > 0))
            {
                Console.WriteLine("Rainy winter");
            }
            else Console.WriteLine("Not rainy or not winter");
        }
    }
}
