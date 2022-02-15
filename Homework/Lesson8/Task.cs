using System;

namespace Lesson8
{
    class Task
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {

                Console.WriteLine("Hello! What is your name?");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();

                Console.WriteLine("How old are you");
                Properties.Settings.Default.UserAge = Convert.ToInt32(Console.ReadLine());
                Properties.Settings.Default.Save();

                Console.WriteLine("What do you do for a living?");
                Properties.Settings.Default.UserProfession = Console.ReadLine();
                Properties.Settings.Default.Save();

            }
            string greeting = Properties.Settings.Default.Greeting;
            string userName = Properties.Settings.Default.UserName;
            int userAge = Properties.Settings.Default.UserAge;
            string userProfession = Properties.Settings.Default.UserProfession;

            Console.WriteLine($"{greeting}, {userName}! " +
                              $"You are {userAge} years old and your profession is {userProfession}.");
        }
    }
}


