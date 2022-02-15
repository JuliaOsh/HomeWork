using System;

namespace Lesson4_3
{
    class Task3
    {
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the month");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetSeason(monthNumber));          

            static string GetSeason(int monthNumber)
            {
                if ((monthNumber == 1) || (monthNumber == 2) || (monthNumber == 12))
                {
                    return Convert.ToString(Season.Winter);
                }
                else if ((monthNumber == 3) || (monthNumber == 4) || (monthNumber == 5))
                {
                    return Convert.ToString(Season.Spring);
                }
                else if ((monthNumber == 6) || (monthNumber == 7) || (monthNumber == 8))
                {
                    return Convert.ToString(Season.Summer);
                }
                else if ((monthNumber == 9) || (monthNumber == 10) || (monthNumber == 11))
                {
                    return Convert.ToString(Season.Autumn);
                }
                else
                {
                    return "Error: Enter the number from 1 to 12";
                }           
            }
        }
    }
}
