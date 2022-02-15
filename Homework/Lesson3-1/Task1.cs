using System;

namespace Array
{
    class Task1
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array[i, i]);
            }
        }
    }
}