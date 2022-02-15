using System;

namespace Lesson2_2_switch
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine(monthName);

        }
    }
}
