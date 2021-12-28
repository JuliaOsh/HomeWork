using System;

namespace Lesson3_2
{
    class Task2
    {
        static void Main(string[] args)
        {
            string[,] addressBook = new string[5, 2];

            string contactName;
            string phoneNumberOrEmail;

            for (int i = 0; i < addressBook.GetLength(0); i++)
            {
                for (int j = 0; j < addressBook.GetLength(1); j++)
                {
                    Console.WriteLine("Contact name: ");
                    contactName = Console.ReadLine();

                    Console.WriteLine("Phone number or email address: ");
                    phoneNumberOrEmail = Console.ReadLine();

                    addressBook[i, j] = contactName;
                    addressBook[i, ++j] = phoneNumberOrEmail;                    
                }
            }
            Console.WriteLine("");
            Console.WriteLine("ADDRESS BOOK");
            Console.WriteLine($"{addressBook[0, 0]} -- {addressBook[0, 1]}");
            Console.WriteLine($"{addressBook[1, 0]} -- {addressBook[1, 1]}");
            Console.WriteLine($"{addressBook[2, 0]} -- {addressBook[2, 1]}");
            Console.WriteLine($"{addressBook[3, 0]} -- {addressBook[3, 1]}");
            Console.WriteLine($"{addressBook[4, 0]} -- {addressBook[4, 1]}");           
        }
    }
}
