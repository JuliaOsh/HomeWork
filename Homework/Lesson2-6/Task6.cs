using System;

namespace test
{
    class Program
    {
        enum Schedule
        {
            Monday    = 0b1000000,
            Tuesday   = 0b0100000,
            Wednesday = 0b0010000,
            Thursday = 0b0001000,
            Friday    = 0b0000100,
            Saturday  = 0b0000010,
            Sunday    = 0b0000001,
        };
        static void Main(string[] args)
        {
            Console.WriteLine($"Working days of Office: ");
            Schedule Office = (Schedule)0b0001000;

            bool isMonday    = ((Office & Schedule.Monday) == Schedule.Monday);
            bool isTuesday   = ((Office & Schedule.Tuesday) == Schedule.Tuesday);
            bool isWednesday = ((Office & Schedule.Wednesday) == Schedule.Wednesday);
            bool isThursday = ((Office & Schedule.Thursday) == Schedule.Thursday);
            bool isFriday    = ((Office & Schedule.Friday) == Schedule.Friday);
            bool isSaturday  = ((Office & Schedule.Saturday) == Schedule.Saturday);
            bool isSunday    = ((Office & Schedule.Sunday) == Schedule.Sunday);

            if (isMonday)    { Console.WriteLine(Schedule.Monday); }
            if (isTuesday)   { Console.WriteLine(Schedule.Tuesday); }
            if (isWednesday) { Console.WriteLine(Schedule.Wednesday); }
            if (isThursday) { Console.WriteLine(Schedule.Thursday); }
            if (isFriday)    { Console.WriteLine(Schedule.Friday); }
            if (isSaturday)  { Console.WriteLine(Schedule.Saturday); }
            if (isSunday)    { Console.WriteLine(Schedule.Sunday); }

        }
    }
}
