using System;

namespace Lesson3_4
{
    class Task4
    {
        static void Main(string[] args)
        {
            string[,] seaWar = new string[10, 10];

            for (int i = 0; i < seaWar.GetLength(0); i++)
            {
                for (int j = 0; j < seaWar.GetLength(1); j++)
                {
                    seaWar[i, j] = "O";
                }
            }

            seaWar[0, 0] = "X";
            seaWar[1, 0] = "X";
            seaWar[3, 0] = "X";
            seaWar[6, 0] = "X";
            seaWar[7, 0] = "X";
            seaWar[8, 0] = "X";
            seaWar[9, 0] = "X";
            seaWar[3, 1] = "X";
            seaWar[3, 2] = "X";
            seaWar[9, 2] = "X";
            seaWar[9, 3] = "X";
            seaWar[1, 4] = "X";
            seaWar[1, 5] = "X";
            seaWar[6, 5] = "X";
            seaWar[1, 6] = "X";
            seaWar[3, 8] = "X";
            seaWar[5, 8] = "X";
            seaWar[8, 8] = "X";
            seaWar[0, 9] = "X";
            seaWar[8, 9] = "X";

            for (int j = 0; j < seaWar.GetLength(0); j++)
            {
                for (int i = 0; i < seaWar.GetLength(1); i++)
                {
                    Console.Write(seaWar[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
