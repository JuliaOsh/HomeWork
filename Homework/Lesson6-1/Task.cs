using System;
using System.Diagnostics;

namespace Lesson6_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                Console.WriteLine($"{processes[i].Id} {processes[i].ProcessName}");
            }

            Console.WriteLine();
            Killing();

            static void Killing()
            {
                Console.WriteLine("Enter the names or the ID-s of the processes that you want to kill separated by space: ");
                string[] processesToKill = Console.ReadLine().Split(' ');

                for (int i = 0; i < processesToKill.Length; i++)
                {
                    Process[] processName = Process.GetProcessesByName(processesToKill[i]);
                    
                    for (int j = 0; j < processName.Length; j++)
                    {
                        processName[j].Kill();
                    }
                }
           
                for (int j = 0; j < processesToKill.Length; j++)
                {
                    try
                    {
                        Process processId = Process.GetProcessById(Convert.ToInt32(processesToKill[j]));
                        processId.Kill();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception found: {ex.Message}");
                    }                                                       
                }                               
            }
        }
    }
}
